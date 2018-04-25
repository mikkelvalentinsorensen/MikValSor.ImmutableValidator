﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Class for validating value types, object and type definitions to check weather they are immutable.
	/// </summary>
	public class ImmutableValidator
	{
		/// <summary>
		///		Construct a new instance of Immutable Validator.
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
				EnsureImmutable(target.GetType(), true);
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
		///		Return True if Type garentirs immutablilty.
		/// </returns>
		public bool IsImmutable(Type targetType)
		{
			if (targetType == null) return true;
			try
			{
				EnsureImmutable(targetType, false);
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
		public void EnsureImmutable(object target)
		{
			if (target == null) return;
			EnsureImmutable(target.GetType(), true);
		}

		/// <summary>
		///		Ensures type garenties object is immutable. 
		/// </summary>
		/// <param name="targetType">
		///		Targeted type for immutable validation.
		/// </param>
		public void EnsureImmutable(Type targetType)
		{
			if (targetType == null) return;
			EnsureImmutable(targetType, false);
		}

		private readonly Dictionary<string, bool> PreviousResults = new Dictionary<string, bool>()
			{
				{typeof(int).FullName, true },
				{typeof(bool).FullName, true },
				{typeof(byte).FullName, true },
				{typeof(char).FullName, true },
				{typeof(decimal).FullName, true },
				{typeof(double).FullName, true },
				{typeof(float).FullName, true },
				{typeof(long).FullName, true },
				{typeof(sbyte).FullName, true },
				{typeof(short).FullName, true },
				{typeof(string).FullName, true },
				{typeof(uint).FullName, true },
				{typeof(ulong).FullName, true },
				{typeof(ushort).FullName, true }
			};
		private readonly Dictionary<string, bool> InstancePreviousResults = new Dictionary<string, bool>()
			{
				{typeof(int).FullName, true },
				{typeof(bool).FullName, true },
				{typeof(byte).FullName, true },
				{typeof(char).FullName, true },
				{typeof(decimal).FullName, true },
				{typeof(double).FullName, true },
				{typeof(float).FullName, true },
				{typeof(long).FullName, true },
				{typeof(sbyte).FullName, true },
				{typeof(short).FullName, true },
				{typeof(string).FullName, true },
				{typeof(uint).FullName, true },
				{typeof(ulong).FullName, true },
				{typeof(ushort).FullName, true }
			};
		private readonly object InsertionLockObject = new object();

		private bool TryGetPreviousResult(Type type, bool instance, out bool result)
		{
			var results = instance ? InstancePreviousResults : PreviousResults;

			return results.TryGetValue(type.FullName, out result);
		}

		private void AddResult(Type type, bool instance, bool result)
		{
			var results = instance ? InstancePreviousResults : PreviousResults;
			var name = type.FullName;

			if (results.ContainsKey(name)) return;

			lock (InsertionLockObject)
			{
				if (results.ContainsKey(name)) return;
				results.Add(name, result);
			}
		}

		private void EnsureImmutable(Type targetType, bool instance, List<Type> inStack = null)
		{
			if (TryGetPreviousResult(targetType, instance, out bool previousResult))
			{
				if (previousResult) return;
			}

			if (inStack == null) inStack = new List<Type>();
			inStack.Add(targetType);
			EnsureImmutableUncached(targetType, instance, inStack);

			AddResult(targetType, instance, true);
		}

		private void EnsureImmutableUncached(Type targetType, bool instance, List<Type> inStack)
		{
			if (targetType.IsEnum)
			{
				return;
			}
			if (targetType.IsInterface)
			{
				throw new TypeIsInterfaceException(targetType);
			}
			if (targetType.IsArray)
			{
				throw new TypeIsArrayException(targetType);
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

			if (!instance && targetType.IsClass)
			{
				if (!targetType.IsSealed)
				{
					throw new ClassNotSealedException(targetType);
				}
			}

			CheckAllFields(targetType, inStack);
			CheckAllProperties(targetType, inStack);
		}

		private void CheckAllFields(Type targetType, List<Type> inStack)
		{
			var fields = GetInstanceFields(targetType);
			fields = fields.Where((f) => !inStack.Contains(f.FieldType)).ToArray();
			foreach (var f in fields) EnsureImmutable(f.FieldType, false, inStack);
		}
		private void CheckAllProperties(Type targetType, List<Type> inStack)
		{
			var properties = targetType.GetProperties();
			properties = properties.Where((p) => !inStack.Contains(p.PropertyType)).ToArray();
			foreach (var p in properties) EnsureImmutable(p.PropertyType, false, inStack);
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

		private IEnumerable<FieldInfo> GetInstanceFields(Type targetType)
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
	}
}
