using System;
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
			return new TypeImmutableValidator().IsImmutable(targetType);
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
			new TypeImmutableValidator().EnsureImmutable(targetType);
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
		private class InstanceImmutableValidator
		{
			public bool Validate(object target)
			{
				return Validate(target, new List<object>());
			}

			private bool Validate(object target, List<object> stack)
			{
				//If object has already been checked, or is in the process of being checked skip it.
				if (stack.Contains(target))
				{
					return true;
				}
				stack.Add(target);

				//Rule 1: null in considered immutable.
				if (target == null)
				{
					return true;
				}

				var targetType = target.GetType();

				//Rule 2: If type of instance is considered immutable, instance will always be immutable.
				if (new TypeImmutableValidator().IsImmutable(targetType))
				{
					return true;
				}

				//while for Rule5
				while (targetType == null)
				{

					//Rule 3: All fields value of an instance must be immutable according to instance immutablilty rules.
					foreach (var fieldInfo in ImmutableValidator.GetInstanceFields(targetType))
					{
						object fieldValue;
						try
						{
							fieldValue = fieldInfo.GetValue(target);
						}
						catch (Exception e)
						{
							throw new UnableToGetFieldValueException(target, fieldInfo, e);
						}
						try
						{
							var fieldResult = Validate(fieldValue, stack);
							if (!fieldResult) return false;
						}
						catch (NotImmutableException n)
						{
							throw new InstanceFieldValueNotImmutableException(target, fieldInfo, fieldValue, n);
						}
					}

					//Rule 4: All properties value of an instance must be immutable according to instance immutablilty rules.
					foreach (var propertyInfo in targetType.GetProperties())
					{
						object propertyValue;

						try
						{
							propertyValue = propertyInfo.GetValue(target);

						}
						catch (Exception e)
						{
							throw new UnableToGetPropertyValueException(target, propertyInfo, e);
						}
						try
						{
							var propertyResult = Validate(propertyValue, stack);
							if (!propertyResult) return false;
						}
						catch (NotImmutableException n)
						{
							throw new InstancePropertyValueNotImmutableException(target, propertyInfo, propertyValue, n);
						}
					}

					//Rule 5: Rules 3 & 4 should be validated on all inhereted class.
					targetType = targetType.BaseType;
				}

				return true;
			}
		}

		private class TypeImmutableValidator
		{
			public void EnsureImmutable(Type type)
			{
				var result = Validate(type);
				if (result == TypeImmutableValidationResult.MightBeImmutable)
				{
					throw new TypeDoesNotGuaranteeImmutabilityException(type);
				}
			}

			public bool IsImmutable(Type type)
			{
				if (type == null) throw new ArgumentNullException(nameof(type));
				try
				{
					var result = Validate(type);
					return result == TypeImmutableValidationResult.IsImmutable;
				}
				catch (Exception)
				{
					return false;
				}
			}

			private TypeImmutableValidationResult Validate(Type targetType)
			{
				return Validate(targetType, false, new List<string>());
			}

			private TypeImmutableValidationResult Validate(Type type, bool isBaseType, List<string> stack)
			{
				//If type has already been checked, or is in the process of being checked skip it.
				var stackName = $"{isBaseType}|{type.FullName}";
				if (stack.Contains(stackName))
				{
					return TypeImmutableValidationResult.IsImmutable;
				}
				stack.Add(stackName);

				//Rule 0: Following types are considered immutable: bool, byte, char, decimal, double, float, int, long, sbyte, short,	string,	uint, ulong and ushort
				if (TypesConsideredImmutable.ContainsKey(type))
				{
					return TypeImmutableValidationResult.IsImmutable;
				}

				//Rule 1: Enums are Immutable.
				if (type.IsEnum)
				{
					return TypeImmutableValidationResult.IsImmutable;
				}

				//Rule 2: Arrays are muteable.
				if (type.IsArray)
				{
					throw new TypeIsArrayException(type);
				}

				var result = TypeImmutableValidationResult.IsImmutable;

				//Rule 3: Instances of interfaces can be both muttable and immutable.
				if (type.IsInterface)
				{
					result = TypeImmutableValidationResult.MightBeImmutable;
				}


				if (type.IsClass)
				{
					//Rule 4: Class types must be sealed to ensure immutability on type level. 
					if (!type.IsSealed)
					{
						if (!isBaseType)
						{
							result = TypeImmutableValidationResult.MightBeImmutable;
						}
					}

					//Rule 5: Class base types must be immutable for type to be immutable.
					if (type.BaseType != null)
					{
						try
						{
							TypeImmutableValidationResult baseTypeResult = Validate(type.BaseType, true, stack);
							if (baseTypeResult == TypeImmutableValidationResult.MightBeImmutable) result = TypeImmutableValidationResult.MightBeImmutable;
						}
						catch (NotImmutableException n)
						{
							throw new BaseClassNotImmutableException(type.BaseType, type, n);
						}
					}
				}

				//Interfaces, Struct and Class fields
				foreach (var fieldInfo in ImmutableValidator.GetInstanceFields(type))
				{
					//Rule 6: Interfaces, structs and classes fields must be readonly.
					if (!fieldInfo.IsInitOnly)
					{
						throw new FieldIsNotInitOnlyException(type, fieldInfo);
					}

					//Rule 7: Interfaces, structs and classes fields must be immutable.
					try
					{
						var fieldTypeResult = Validate(fieldInfo.FieldType, false, stack);
						if (fieldTypeResult == TypeImmutableValidationResult.MightBeImmutable) result = TypeImmutableValidationResult.MightBeImmutable;
					}
					catch (NotImmutableException n)
					{
						throw new TypeFieldNotImmutableException(type, fieldInfo, n);
					}
				}

				//Interfaces, Struct and Class fields
				foreach (var propertyInfo in type.GetProperties())
				{
					//Rule 8: Interfaces, structs and classes properties cannot have setters.
					if (propertyInfo.CanWrite)
					{
						throw new PropertyCanWriteException(type, propertyInfo);
					}

					//Rule 9: Interfaces, structs and classes properties must be immutable.
					try
					{
						var propertyTypeResult = Validate(propertyInfo.PropertyType, false, stack);
						if (propertyTypeResult == TypeImmutableValidationResult.MightBeImmutable) result = TypeImmutableValidationResult.MightBeImmutable;
					}
					catch (NotImmutableException n)
					{
						throw new TypePropertyNotImmutableException(type, propertyInfo, n);
					}
				}

				return result;
			}

			private readonly Dictionary<Type, bool> TypesConsideredImmutable = new Dictionary<Type, bool>()
			{
				{typeof(int), true },
				{typeof(bool), true },
				{typeof(byte), true },
				{typeof(char), true },
				{typeof(decimal), true },
				{typeof(double), true },
				{typeof(float), true },
				{typeof(long), true },
				{typeof(sbyte), true },
				{typeof(short), true },
				{typeof(string), true },
				{typeof(uint), true },
				{typeof(ulong), true },
				{typeof(ushort), true }
			};
		}
	}
}
