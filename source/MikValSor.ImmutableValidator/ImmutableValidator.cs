﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Class for validating value types, object and type definitions to check if they are immutable.
	/// </summary>
	public class ImmutableValidator
	{
		/// <summary>
		///		Construct a new instance of ImmutableValidator.
		/// </summary>
		public ImmutableValidator()
		{
		}

		/// <summary>
		///		Checks if target object is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted object for immutable validation.
		/// </param>
		/// <returns>
		///		Returns True if object is immutable.
		/// </returns>
		public bool IsImmutable(object target)
		{
			if (target == null) return true;
			try
			{
				EnsureImmutable(target.GetType(), true, false);
			}
			catch (NotImmutableException)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		///		Checks if type garenties object is immutable. 
		/// </summary>
		/// <param name="targetType">
		///		Targeted type for immutable validation.
		/// </param>
		/// <returns>
		///		Return True if type guarantee immutablilty.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		Throws System.ArgumentNullException if targetType is null.
		/// </exception>
		public bool IsImmutable(Type targetType)
		{
			if (targetType == null) throw new ArgumentNullException(nameof(targetType));
			try
			{
				EnsureImmutable(targetType, false, false);
			}
			catch (NotImmutableException)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		///		Ensures target object is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted object for immutable validation.
		/// </param>
		/// <exception cref="ClassNotSealedException">
		///		Throws MikValSor.Immutable.ClassNotSealedException if target or member of target should have been sealed.
		/// </exception>
		/// <exception cref="FieldIsNotInitOnlyException">
		///		Throws MikValSor.Immutable.FieldIsNotInitOnlyException if target or member of target have fields that are setable.
		/// </exception>
		/// <exception cref="PropertyCanWriteException">
		///		Throws MikValSor.Immutable.PropertyCanWriteException if target or member of target should have properties that can be set.
		/// </exception>
		/// <exception cref="TypeIsArrayException">
		///		Throws MikValSor.Immutable.TypeIsArrayException if target or member of target have an array.
		/// </exception>
		/// <exception cref="TypeIsInterfaceException">
		///		Throws MikValSor.Immutable.TypeIsInterfaceException if target or member of target is an interface.
		/// </exception>
		public void EnsureImmutable(object target)
		{
			if (target == null) return;
			EnsureImmutable(target.GetType(), true, false);
		}

		/// <summary>
		///		Ensures type garenties object is immutable. 
		/// </summary>
		/// <param name="targetType">
		///		Targeted type for immutable validation.
		/// </param>
		/// <exception cref="ArgumentNullException">
		///		Throws System.ArgumentNullException if targetType is null.
		/// </exception>
		/// <exception cref="ClassNotSealedException">
		///		Throws MikValSor.Immutable.ClassNotSealedException if targetType or member of targetType should have been sealed.
		/// </exception>
		/// <exception cref="FieldIsNotInitOnlyException">
		///		Throws MikValSor.Immutable.FieldIsNotInitOnlyException if targetType or member of targetType have fields that are setable.
		/// </exception>
		/// <exception cref="PropertyCanWriteException">
		///		Throws MikValSor.Immutable.PropertyCanWriteException if targetType or member of targetType should have properties that can be set.
		/// </exception>
		/// <exception cref="TypeIsArrayException">
		///		Throws MikValSor.Immutable.TypeIsArrayException if targetType or member of targetType have an array.
		/// </exception>
		/// <exception cref="TypeIsInterfaceException">
		///		Throws MikValSor.Immutable.TypeIsInterfaceException if targetType or member of targetType is an interface.
		/// </exception>
		public void EnsureImmutable(Type targetType)
		{
			if (targetType == null) throw new ArgumentNullException(nameof(targetType));
			EnsureImmutable(targetType, false, false);
		}

		private ResultCache ResultCache = new ResultCache();

		private void EnsureImmutable(Type targetType, bool instance, bool baseType, List<Type> inStack = null)
		{
			if (ResultCache.TryGetResult(targetType, instance, baseType, out bool previousResult))
			{
				if (previousResult) return;
			}

			if (inStack == null) inStack = new List<Type>();
			inStack.Add(targetType);
			EnsureImmutableUncached(targetType, instance, baseType, inStack);

			ResultCache.AddResult(targetType, instance, baseType);
		}

		private void EnsureImmutableUncached(Type targetType, bool instance, bool baseType, List<Type> inStack)
		{
			if (targetType.IsInterface)
			{
				throw new TypeIsInterfaceException(targetType);
			}
			if (targetType.IsArray)
			{
				throw new TypeIsArrayException(targetType);
			}
			if (targetType.IsEnum)
			{
				return;
			}

#if NET471
			if (!IsReadonlyStruct(targetType))
			{
#endif
			EnsureAllFieldsAreReadonly(targetType);
			EnsureNoProppertiesHasSetters(targetType);
#if NET471
			}
#endif

			if (!baseType && !instance && targetType.IsClass)
			{
				if (!targetType.IsSealed)
				{
					throw new ClassNotSealedException(targetType);
				}
			}

			CheckAllFields(targetType, inStack);
			CheckAllProperties(targetType, inStack);

			if (targetType.IsClass && targetType.BaseType != null)
			{
				EnsureImmutable(targetType.BaseType, instance, true, inStack);
			}
		}

		private void CheckAllFields(Type targetType, List<Type> inStack)
		{
			var fields = GetInstanceFields(targetType);
			fields = fields.Where((f) => !inStack.Contains(f.FieldType)).ToArray();
			foreach (var f in fields)
			{
				try
				{
					EnsureImmutable(f.FieldType, false, false, inStack);
				}
				catch (TypeIsArrayException)
				{
					//Exceptions to allow for immuatble collection althoug inner is a safe array called list;
					if (targetType.FullName.StartsWith("MikValSor.Immutable.ImmutableCollection`1[") && f.Name == "m_array")
					{
						var elementType = f.FieldType.GetElementType();
						EnsureImmutable(elementType, false, false, inStack);
					}
					else
					{
						throw;
					}
				}
			}
		}
		private void CheckAllProperties(Type targetType, List<Type> inStack)
		{
			var properties = targetType.GetProperties();
			properties = properties.Where((p) => !inStack.Contains(p.PropertyType)).ToArray();
			foreach (var p in properties) EnsureImmutable(p.PropertyType, false, false, inStack);
		}

		private void EnsureAllFieldsAreReadonly(Type targetType)
		{
			var fields = GetInstanceFields(targetType).ToArray();

			foreach (var field in fields)
			{
				if (!field.IsInitOnly)
				{
					throw new FieldIsNotInitOnlyException(targetType, field);
				}
			}
		}

		private static IEnumerable<FieldInfo> GetInstanceFields(Type targetType)
		{
			var privateFields = targetType.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			foreach (var f in privateFields) yield return f;

			var publicFields = targetType.GetFields().Where(f => !f.IsStatic);
			foreach (var f in publicFields) yield return f;
		}

		private void EnsureNoProppertiesHasSetters(Type targetType)
		{
			var properties = targetType.GetProperties();

			foreach ( var property in properties)
			{
				if (property.CanWrite)
				{
					throw new PropertyCanWriteException(targetType, property);
				}
			}
		}

#if NET471
		private bool IsReadonlyStruct(Type targetType)
		{
			if (targetType.IsValueType)
			{
				return IsComplierMarkedReadonly(targetType);
			}
			return false;
		}

		private bool IsComplierMarkedReadonly(Type targetType)
		{
			var customAttributes = targetType.GetCustomAttributes(false);

			return customAttributes.Any(a => a is System.Runtime.CompilerServices.IsReadOnlyAttribute);
		}
#endif
		private class TypeImmutableValidator
		{
			public TypeImmutableValidationResult Validate(Type targetType)
			{
				return Validate(targetType, false, new List<Type>());
			}
			private TypeImmutableValidationResult Validate(Type targetType, bool isBaseType, List<Type> stack)
			{
				stack.Add(targetType);
				
				if (targetType.IsInterface)
				{
					return TypeImmutableValidationResult.MightBeImmutable;
				}
				if (targetType.IsArray)
				{
					return TypeImmutableValidationResult.IsNotImmutable;
				}
				if (targetType.IsEnum)
				{
					return TypeImmutableValidationResult.IsImmutable;
				}

				if (targetType.IsClass)
				{
					if (!isBaseType)
					{
						if (!targetType.IsSealed)
						{
							return TypeImmutableValidationResult.MightBeImmutable;
						}
					}
					if (targetType.BaseType != null)
					{
						var baseTypeResult = Validate(targetType, true, stack);
						if (baseTypeResult != TypeImmutableValidationResult.IsImmutable)
						{
							return baseTypeResult;
						}
					}
				}

				foreach (var fieldInfo in ImmutableValidator.GetInstanceFields(targetType))
				{
					if (!fieldInfo.IsInitOnly)
					{
						return TypeImmutableValidationResult.IsNotImmutable;
					}
				}

#if NET471
			if (!IsReadonlyStruct(targetType))
			{
#endif
				EnsureAllFieldsAreReadonly(targetType);
				EnsureNoProppertiesHasSetters(targetType);
#if NET471
			}
#endif

				CheckAllFields(targetType, inStack);
				CheckAllProperties(targetType, inStack);

				if (targetType.IsClass && targetType.BaseType != null)
				{
					EnsureImmutable(targetType.BaseType, instance, true, inStack);
				}
			}
		}
	}
}
