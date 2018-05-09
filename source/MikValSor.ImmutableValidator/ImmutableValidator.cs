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
		/// <param name="instance">
		///		Targeted object for immutable validation.
		/// </param>
		/// <returns>
		///		Returns True if object is immutable.
		/// </returns>
		public bool IsImmutable(object instance)
		{
			try
			{
				Validate(instance);
				return true;
			}
			catch (NotImmutableException)
			{
				return false;
			}
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
		#warning documenteded exceptions needs update
		public void EnsureImmutable(object target)
		{
			Validate(target);
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
		#warning documenteded exceptions needs update
		public void EnsureImmutable(Type type)
		{
			var result = Validate(type);
			if (result == TypeImmutableValidationResult.MightBeImmutable)
			{
				throw new TypeDoesNotGuaranteeImmutabilityException(type);
			}
		}

		private static IEnumerable<FieldInfo> GetInstanceFields(Type targetType)
		{
			var privateFields = targetType.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			foreach (var f in privateFields) yield return f;

			var publicFields = targetType.GetFields().Where(f => !f.IsStatic);
			foreach (var f in publicFields) yield return f;
		}

		private void Validate(object target)
		{
			Validate(target, new List<object>());
		}

		private void Validate(object target, List<object> stack)
		{
			//If object has already been checked, or is in the process of being checked skip it.
			if (stack.Contains(target))
			{
				return;
			}
			stack.Add(target);

			//Rule 1: null in considered immutable.
			if (target == null)
			{
				return;
			}

			var targetType = target.GetType();

			//Rule 2: If type of instance is considered immutable, instance will always be immutable.
			try
			{
				EnsureImmutable(targetType);
				return;
			}
			catch (TypeDoesNotGuaranteeImmutabilityException)
			{
				//Continue Validation
			}

			//while for Rule5
			while (targetType != null)
			{

				//Rule 3: All fields value of an instance must be immutable according to instance immutablilty rules.
				foreach (var fieldInfo in GetInstanceFields(targetType))
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
						Validate(fieldValue, stack);
					}
					catch (TypeIsArrayException t)
					{
						//Rule 3a: Exception to allow collections we allow for a single inner array in MikValSor.Immutable.ImmutableCollection`1.
						if (targetType.FullName.StartsWith("MikValSor.Immutable.ImmutableCollection`1[") && fieldInfo.Name == "m_array")
						{
							//Test all array elements;
							foreach (object arrayValue in (fieldValue as Array))
							{
								Validate(arrayValue, stack);
							}
						}
						else
						{
							throw new InstanceFieldValueNotImmutableException(target, fieldInfo, fieldValue, t);
						}
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
					catch (TargetParameterCountException t)
					{
						//Rule 4a: Exception get_Item methods are validated.
						if (propertyInfo.GetMethod.Name == "get_Item")
						{
							continue;
						}
						else
						{
							throw new UnableToGetPropertyValueException(target, propertyInfo, t);
						}
					}
					catch (Exception e)
					{
						throw new UnableToGetPropertyValueException(target, propertyInfo, e);
					}
					try
					{
						Validate(propertyValue, stack);
					}
					catch (NotImmutableException n)
					{
						throw new InstancePropertyValueNotImmutableException(target, propertyInfo, propertyValue, n);
					}
				}

				//Rule 5: Rules 3 & 4 should be validated on all inhereted class.
				targetType = targetType.BaseType;
			}

			return;
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

			//Rule 1: Enums are immutable.
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
			foreach (var fieldInfo in GetInstanceFields(type))
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
				catch (TypeIsArrayException t)
				{
					//Rule 7a: Exception to allow collections we allow for a single inner array in MikValSor.Immutable.ImmutableCollection`1.
					if (type.FullName.StartsWith("MikValSor.Immutable.ImmutableCollection`1[") && fieldInfo.Name == "m_array")
					{
						//Test element type;
						var arrayElementTypeResult = Validate(fieldInfo.FieldType.GetElementType(), false, stack);
						if (arrayElementTypeResult == TypeImmutableValidationResult.MightBeImmutable) result = TypeImmutableValidationResult.MightBeImmutable;
					}
					else
					{
						throw new TypeFieldNotImmutableException(type, fieldInfo, t);
					}
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
