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
		private readonly static Lazy<ImmutableValidator> lazyInstance = new Lazy<ImmutableValidator>(() => new ImmutableValidator());
		/// <summary>
		///		Instance of ImmutableValidator
		/// </summary>
		public static ImmutableValidator Instance => lazyInstance.Value;

		/// <summary>
		///		Construct a new instance of ImmutableValidator.
		/// </summary>
		public ImmutableValidator()
		{
		}

		/// <summary>
		///		int is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted int for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("int are immutable, so do not validate for this")]
		public bool IsImmutable(int instance)
		{
			return true;
		}

		/// <summary>
		///		bool is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted bool for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("bool are immutable, so do not validate for this")]
		public bool IsImmutable(bool instance)
		{
			return true;
		}

		/// <summary>
		///		byte is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted byte for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("byte are immutable, so do not validate for this")]
		public bool IsImmutable(byte instance)
		{
			return true;
		}

		/// <summary>
		///		char is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted char for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("char are immutable, so do not validate for this")]
		public bool IsImmutable(char instance)
		{
			return true;
		}

		/// <summary>
		///		decimal is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted decimal for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("decimal are immutable, so do not validate for this")]
		public bool IsImmutable(decimal instance)
		{
			return true;
		}

		/// <summary>
		///		float is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted float for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("float are immutable, so do not validate for this")]
		public bool IsImmutable(float instance)
		{
			return true;
		}

		/// <summary>
		///		long is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted long for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("long are immutable, so do not validate for this")]
		public bool IsImmutable(long instance)
		{
			return true;
		}

		/// <summary>
		///		sbyte is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted sbyte for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("sbyte are immutable, so do not validate for this")]
		public bool IsImmutable(sbyte instance)
		{
			return true;
		}

		/// <summary>
		///		short is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted short for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("short are immutable, so do not validate for this")]
		public bool IsImmutable(short instance)
		{
			return true;
		}

		/// <summary>
		///		string is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted string for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("string are immutable, so do not validate for this")]
		public bool IsImmutable(string instance)
		{
			return true;
		}

		/// <summary>
		///		uint is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted uint for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("uint are immutable, so do not validate for this")]
		public bool IsImmutable(uint instance)
		{
			return true;
		}

		/// <summary>
		///		ulong is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted ulong for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("ulong are immutable, so do not validate for this")]
		public bool IsImmutable(ulong instance)
		{
			return true;
		}

		/// <summary>
		///		ushort is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted ushort for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("ushort are immutable, so do not validate for this")]
		public bool IsImmutable(ushort instance)
		{
			return true;
		}

		/// <summary>
		///		Enums are immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted enum for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("Enums are immutable, so do not validate for this")]
		public bool IsImmutable(Enum instance)
		{
			return true;
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
				Validate(instance, new List<object>());
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
		/// <param name="type">
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
				var result = Validate(type, false, new List<string>());
				return result == TypeImmutableValidationResult.IsImmutable;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		///		int is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted int for immutable validation.
		/// </param>
		[Obsolete("int are immutable, so do not validate for this")]
		public void EnsureImmutable(int target)
		{
		}

		/// <summary>
		///		bool is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted bool for immutable validation.
		/// </param>
		[Obsolete("bool are immutable, so do not validate for this")]
		public void EnsureImmutable(bool target)
		{
		}

		/// <summary>
		///		byte is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted byte for immutable validation.
		/// </param>
		[Obsolete("byte are immutable, so do not validate for this")]
		public void EnsureImmutable(byte target)
		{
		}

		/// <summary>
		///		char is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted char for immutable validation.
		/// </param>
		[Obsolete("char are immutable, so do not validate for this")]
		public void EnsureImmutable(char target)
		{
		}

		/// <summary>
		///		decimal is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted decimal for immutable validation.
		/// </param>
		[Obsolete("decimal are immutable, so do not validate for this")]
		public void EnsureImmutable(decimal target)
		{
		}

		/// <summary>
		///		float is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted float for immutable validation.
		/// </param>
		[Obsolete("float are immutable, so do not validate for this")]
		public void EnsureImmutable(float target)
		{
		}

		/// <summary>
		///		long is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted long for immutable validation.
		/// </param>
		[Obsolete("long are immutable, so do not validate for this")]
		public void EnsureImmutable(long target)
		{
		}

		/// <summary>
		///		sbyte is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted sbyte for immutable validation.
		/// </param>
		[Obsolete("sbyte are immutable, so do not validate for this")]
		public void EnsureImmutable(sbyte target)
		{
		}

		/// <summary>
		///		short is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted short for immutable validation.
		/// </param>
		[Obsolete("short are immutable, so do not validate for this")]
		public void EnsureImmutable(short target)
		{
		}

		/// <summary>
		///		string is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted string for immutable validation.
		/// </param>
		[Obsolete("string are immutable, so do not validate for this")]
		public void EnsureImmutable(string target)
		{
		}

		/// <summary>
		///		uint is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted uint for immutable validation.
		/// </param>
		[Obsolete("uint are immutable, so do not validate for this")]
		public void EnsureImmutable(uint target)
		{
		}

		/// <summary>
		///		ulong is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted ulong for immutable validation.
		/// </param>
		[Obsolete("ulong are immutable, so do not validate for this")]
		public void EnsureImmutable(ulong target)
		{
		}

		/// <summary>
		///		ushort is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted ushort for immutable validation.
		/// </param>
		[Obsolete("ushort are immutable, so do not validate for this")]
		public void EnsureImmutable(ushort target)
		{
		}


		/// <summary>
		///		Enums are immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted enum for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("Enums are immutable, so do not validate for this")]
		public void EnsureImmutable(Enum instance)
		{
		}

		/// <summary>
		///		Ensures target object is immutable.
		/// </summary>
		/// <param name="target">
		///		Targeted object for immutable validation.
		/// </param>
		/// <exception cref="FieldIsNotInitOnlyException">
		///		Throws MikValSor.Immutable.FieldIsNotInitOnlyException if target or member of target have fields that are setable.
		/// </exception>
		/// <exception cref="InstanceFieldValueNotImmutableException">
		///		Throws MikValSor.Immutable.InstanceFieldValueNotImmutableException if target contains field value that is mutable.
		/// </exception>
		/// <exception cref="UnableToGetFieldValueException">
		///		Throws MikValSor.Immutable.UnableToGetFieldValueException if field value was not able to be fetched for validation.
		/// </exception>
		/// <exception cref="PropertyCanWriteException">
		///		Throws MikValSor.Immutable.PropertyCanWriteException if target or member of target should have properties that can be set.
		/// </exception>
		/// <exception cref="UnableToGetPropertyValueException">
		///		Throws MikValSor.Immutable.UnableToGetFieldValueException if property value was not able to be fetched for validation.
		/// </exception>
		/// <exception cref="InstancePropertyValueNotImmutableException">
		///		Throws MikValSor.Immutable.InstancePropertyValueNotImmutableException if target contains property value that is mutable.
		/// </exception>
		/// <exception cref="BaseClassNotImmutableException">
		///		Throws MikValSor.Immutable.BaseClassNotImmutableException if target inheret from type that is mutable.
		/// </exception>
		/// <exception cref="TypeIsArrayException">
		///		Throws MikValSor.Immutable.TypeIsArrayException if target or member of type have an array.
		/// </exception>
		/// <exception cref="TypeFieldNotImmutableException">
		///		Throws MikValSor.Immutable.TypeFieldNotImmutableException if target contains field that is mutable.
		/// </exception>
		/// <exception cref="TypePropertyNotImmutableException">
		///		Throws MikValSor.Immutable.TypePropertyNotImmutableException if target contains property that is mutable.
		/// </exception>
		public void EnsureImmutable(object target)
		{
			Validate(target, new List<object>());
		}

		/// <summary>
		///		Ensures type garenties object is immutable. 
		/// </summary>
		/// <param name="type">
		///		Targeted type for immutable validation.
		/// </param>
		/// <exception cref="FieldIsNotInitOnlyException">
		///		Throws MikValSor.Immutable.FieldIsNotInitOnlyException if type or member of type have fields that are setable.
		/// </exception>
		/// <exception cref="PropertyCanWriteException">
		///		Throws MikValSor.Immutable.PropertyCanWriteException if type or member of type should have properties that can be set.
		/// </exception>
		/// <exception cref="TypeIsArrayException">
		///		Throws MikValSor.Immutable.TypeIsArrayException if type or member of type have an array.
		/// </exception>
		/// <exception cref="BaseClassNotImmutableException">
		///		Throws MikValSor.Immutable.BaseClassNotImmutableException if type inheret from type that is mutable.
		/// </exception>
		/// <exception cref="TypeFieldNotImmutableException">
		///		Throws MikValSor.Immutable.TypeFieldNotImmutableException if type contains field that is mutable.
		/// </exception>
		/// <exception cref="TypePropertyNotImmutableException">
		///		Throws MikValSor.Immutable.TypePropertyNotImmutableException if type contains property that is mutable.
		/// </exception>
		/// <exception cref="TypeDoesNotGuaranteeImmutabilityException">
		///		Throws MikValSor.Immutable.TypeDoesNotGuaranteeImmutabilityException if  instance of type needs to be validated to ensure immutablility.
		/// </exception>
		public void EnsureImmutable(Type type)
		{
			var result = Validate(type, false, new List<string>());
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
