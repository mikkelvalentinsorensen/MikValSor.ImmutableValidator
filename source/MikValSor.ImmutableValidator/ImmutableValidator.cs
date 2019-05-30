// <copyright file="ImmutableValidator.cs">
// Copyright (C) 2018-2019 Mikkel Valentin Sorensen
//
// This file is part of MikValSor.ImmutableValidator.
//
// MikValSor.ImmutableValidator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// MikValSor.ImmutableValidator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with MikValSor.ImmutableValidator. If not, see http://www.gnu.org/licenses/.
// </copyright>
namespace MikValSor.Immutable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>Class for validating value types, object and type definitions to check if they are immutable.</summary>
    public class ImmutableValidator
    {
        private static readonly Lazy<ImmutableValidator> LazyInstance = new Lazy<ImmutableValidator>(() => new ImmutableValidator());

        private readonly Dictionary<Type, bool> typesConsideredImmutable = new Dictionary<Type, bool>()
        {
            { typeof(int), true },
            { typeof(bool), true },
            { typeof(byte), true },
            { typeof(char), true },
            { typeof(decimal), true },
            { typeof(double), true },
            { typeof(float), true },
            { typeof(long), true },
            { typeof(sbyte), true },
            { typeof(short), true },
            { typeof(string), true },
            { typeof(uint), true },
            { typeof(ulong), true },
            { typeof(ushort), true }
        };

        /// <summary>Initializes a new instance of the <see cref="ImmutableValidator"/> class.</summary>
        public ImmutableValidator()
        {
        }

        /// <summary>Gets instance of ImmutableValidator.</summary>
        public static ImmutableValidator Instance => LazyInstance.Value;

        /// <summary><see cref="int"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="int"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("int are immutable, so do not validate for this")]
        public static bool IsImmutable(int instance)
        {
            return true;
        }

        /// <summary><see cref="bool"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="bool"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("bool are immutable, so do not validate for this")]
        public static bool IsImmutable(bool instance) => true;

        /// <summary><see cref="byte"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="byte"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("byte are immutable, so do not validate for this")]
        public static bool IsImmutable(byte instance) => true;

        /// <summary><see cref="char"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="char"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("char are immutable, so do not validate for this")]
        public static bool IsImmutable(char instance) => true;

        /// <summary><see cref="decimal"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="decimal"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("decimal are immutable, so do not validate for this")]
        public static bool IsImmutable(decimal instance) => true;

        /// <summary><see cref="float"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="float"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("float are immutable, so do not validate for this")]
        public static bool IsImmutable(float instance) => true;

        /// <summary><see cref="long"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="long"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("long are immutable, so do not validate for this")]
        public static bool IsImmutable(long instance) => true;

        /// <summary><see cref="sbyte"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="sbyte"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("sbyte are immutable, so do not validate for this")]
        public static bool IsImmutable(sbyte instance) => true;

        /// <summary><see cref="short"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="short"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("short are immutable, so do not validate for this")]
        public static bool IsImmutable(short instance) => true;

        /// <summary><see cref="string"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="string"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("string are immutable, so do not validate for this")]
        public static bool IsImmutable(string instance) => true;

        /// <summary><see cref="uint"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="uint"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("uint are immutable, so do not validate for this")]
        public static bool IsImmutable(uint instance) => true;

        /// <summary><see cref="ulong"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="ulong"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("ulong are immutable, so do not validate for this")]
        public static bool IsImmutable(ulong instance) => true;

        /// <summary><see cref="ushort"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="ushort"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("ushort are immutable, so do not validate for this")]
        public static bool IsImmutable(ushort instance) => true;

        /// <summary><see cref="Enum"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="Enum"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("Enums are immutable, so do not validate for this")]
        public static bool IsImmutable(Enum instance) => true;

        /// <summary><see cref="int"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="int"/> for immutable validation.</param>
        [Obsolete("int are immutable, so do not validate for this")]
        public static void EnsureImmutable(int target)
        {
        }

        /// <summary><see cref="bool"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="bool"/> for immutable validation.</param>
        [Obsolete("bool are immutable, so do not validate for this")]
        public static void EnsureImmutable(bool target)
        {
        }

        /// <summary><see cref="byte"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="byte"/> for immutable validation.</param>
        [Obsolete("byte are immutable, so do not validate for this")]
        public static void EnsureImmutable(byte target)
        {
        }

        /// <summary><see cref="char"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="char"/> for immutable validation.</param>
        [Obsolete("char are immutable, so do not validate for this")]
        public static void EnsureImmutable(char target)
        {
        }

        /// <summary><see cref="decimal"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="decimal"/> for immutable validation.</param>
        [Obsolete("decimal are immutable, so do not validate for this")]
        public static void EnsureImmutable(decimal target)
        {
        }

        /// <summary><see cref="float"/> is immutable."/></summary>
        /// <param name="target">Targeted <see cref="float"/> for immutable validation.</param>
        [Obsolete("float are immutable, so do not validate for this")]
        public static void EnsureImmutable(float target)
        {
        }

        /// <summary><see cref="long"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="long"/> for immutable validation.</param>
        [Obsolete("long are immutable, so do not validate for this")]
        public static void EnsureImmutable(long target)
        {
        }

        /// <summary><see cref="sbyte"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="sbyte"/> for immutable validation.</param>
        [Obsolete("sbyte are immutable, so do not validate for this")]
        public static void EnsureImmutable(sbyte target)
        {
        }

        /// <summary><see cref="short"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="short"/> for immutable validation.</param>
        [Obsolete("short are immutable, so do not validate for this")]
        public static void EnsureImmutable(short target)
        {
        }

        /// <summary><see cref="string"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="string"/> for immutable validation.</param>
        [Obsolete("string are immutable, so do not validate for this")]
        public static void EnsureImmutable(string target)
        {
        }

        /// <summary><see cref="uint"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="uint"/> for immutable validation.</param>
        [Obsolete("uint are immutable, so do not validate for this")]
        public static void EnsureImmutable(uint target)
        {
        }

        /// <summary><see cref="ulong"/> is immutable.</summary>
        /// <param name="target">Targeted ulong for immutable validation.</param>
        [Obsolete("ulong are immutable, so do not validate for this")]
        public static void EnsureImmutable(ulong target)
        {
        }

        /// <summary><see cref="ushort"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="ushort"/> for immutable validation.</param>
        [Obsolete("ushort are immutable, so do not validate for this")]
        public static void EnsureImmutable(ushort target)
        {
        }

        /// <summary><see cref="Enum"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="Enum"/> for immutable validation.</param>
        [Obsolete("Enums are immutable, so do not validate for this")]
        public static void EnsureImmutable(Enum instance)
        {
        }

        /// <summary>Checks if target <see cref="object"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="object"/> for immutable validation.</param>
        /// <returns>Returns true if object is immutable.</returns>
        public bool IsImmutable(object instance)
        {
            try
            {
                this.Validate(instance, new List<object>());
                return true;
            }
            catch (NotImmutableException)
            {
                return false;
            }
        }

        /// <summary>Checks if type garenties object is immutable.</summary>
        /// <param name="type">Targeted type for immutable validation.</param>
        /// <returns>Return true if type guarantee immutablilty.</returns>
        /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> if targetType is null.</exception>
        public bool IsImmutable(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            try
            {
                var result = this.Validate(type, false, new List<string>());
                return result == TypeImmutableValidationResult.IsImmutable;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception)
            {
                return false;
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }

        /// <summary>Ensures target <see cref="object"/> is immutable.</summary>
        /// <param name="target">Targeted <see cref="object"/> for immutable validation.</param>
        /// <exception cref="FieldIsNotInitOnlyException">Throws <see cref="FieldIsNotInitOnlyException"/> if target or member of target have fields that are setable.</exception>
        /// <exception cref="InstanceFieldValueNotImmutableException">Throws <see cref="InstanceFieldValueNotImmutableException"/> if target contains field value that is mutable.</exception>
        /// <exception cref="UnableToGetFieldValueException">Throws <see cref="UnableToGetFieldValueException"/> if field value was not able to be fetched for validation.</exception>
        /// <exception cref="PropertyCanWriteException">Throws <see cref="PropertyCanWriteException"/> if target or member of target should have properties that can be set.</exception>
        /// <exception cref="UnableToGetPropertyValueException">Throws <see cref="UnableToGetFieldValueException"/> if property value was not able to be fetched for validation.</exception>
        /// <exception cref="InstancePropertyValueNotImmutableException">Throws <see cref="InstancePropertyValueNotImmutableException"/> if target contains property value that is mutable.</exception>
        /// <exception cref="BaseClassNotImmutableException">Throws <see cref="BaseClassNotImmutableException"/> if target inheret from type that is mutable.</exception>
        /// <exception cref="TypeIsArrayException">Throws <see cref="TypeIsArrayException"/> if target or member of type have an array.</exception>
        /// <exception cref="TypeFieldNotImmutableException">Throws <see cref="TypeFieldNotImmutableException"/> if target contains field that is mutable.</exception>
        /// <exception cref="TypePropertyNotImmutableException">Throws <see cref="TypePropertyNotImmutableException"/> if target contains property that is mutable.</exception>
        public void EnsureImmutable(object target)
        {
            this.Validate(target, new List<object>());
        }

        /// <summary>Ensures type garenties object is immutable.</summary>
        /// <param name="type">Targeted type for immutable validation.</param>
        /// <exception cref="FieldIsNotInitOnlyException">Throws <see cref="FieldIsNotInitOnlyException"/> if type or member of type have fields that are setable.</exception>
        /// <exception cref="PropertyCanWriteException">Throws <see cref="PropertyCanWriteException"/> if type or member of type should have properties that can be set.</exception>
        /// <exception cref="TypeIsArrayException">Throws <see cref="TypeIsArrayException"/> if type or member of type have an array.</exception>
        /// <exception cref="BaseClassNotImmutableException">Throws <see cref="BaseClassNotImmutableException"/> if type inheret from type that is mutable.</exception>
        /// <exception cref="TypeFieldNotImmutableException">Throws <see cref="TypeFieldNotImmutableException"/> if type contains field that is mutable.</exception>
        /// <exception cref="TypePropertyNotImmutableException">Throws <see cref="TypePropertyNotImmutableException"/> if type contains property that is mutable.</exception>
        /// <exception cref="TypeDoesNotGuaranteeImmutabilityException">Throws <see cref="TypeDoesNotGuaranteeImmutabilityException"/> if  instance of type needs to be validated to ensure immutablility.</exception>
        public void EnsureImmutable(Type type)
        {
            var result = this.Validate(type, false, new List<string>());
            if (result == TypeImmutableValidationResult.MightBeImmutable)
            {
                throw new TypeDoesNotGuaranteeImmutabilityException(type);
            }
        }

        private static IEnumerable<FieldInfo> GetInstanceFields(Type targetType)
        {
            var privateFields = targetType.GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            foreach (var f in privateFields)
            {
                yield return f;
            }

            var publicFields = targetType.GetFields().Where(f => !f.IsStatic);
            foreach (var f in publicFields)
            {
                yield return f;
            }
        }

        private void Validate(object target, List<object> stack)
        {
            // If object has already been checked, or is in the process of being checked skip it.
            if (stack.Contains(target))
            {
                return;
            }

            stack.Add(target);

            // Rule 1: null in considered immutable.
            if (target == null)
            {
                return;
            }

            var targetType = target.GetType();

            // Rule 2: If type of instance is considered immutable, instance will always be immutable.
            try
            {
                this.EnsureImmutable(targetType);
                return;
            }
            catch (TypeDoesNotGuaranteeImmutabilityException)
            {
                // Continue Validation
            }

            // while for Rule5
            while (targetType != null)
            {
                // Rule 3: All fields value of an instance must be immutable according to instance immutablilty rules.
                foreach (var fieldInfo in GetInstanceFields(targetType))
                {
                    object fieldValue;
                    try
                    {
                        fieldValue = fieldInfo.GetValue(target);
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception e)
                    {
                        throw new UnableToGetFieldValueException(fieldInfo, e);
                    }
#pragma warning restore CA1031 // Do not catch general exception types

                    try
                    {
                        this.Validate(fieldValue, stack);
                    }
                    catch (TypeIsArrayException t)
                    {
                        // Rule 3a: Exception to allow collections we allow for a single inner array in MikValSor.Immutable.ImmutableCollection`1.
                        if (targetType.FullName.StartsWith("MikValSor.Immutable.ImmutableCollection`1[", StringComparison.InvariantCulture) && fieldInfo.Name == "m_array")
                        {
                            // Test all array elements;
                            foreach (object arrayValue in fieldValue as Array)
                            {
                                this.Validate(arrayValue, stack);
                            }
                        }
                        else
                        {
                            throw new InstanceFieldValueNotImmutableException(fieldInfo, t);
                        }
                    }
                    catch (NotImmutableException n)
                    {
                        throw new InstanceFieldValueNotImmutableException(fieldInfo, n);
                    }
                }

                // Rule 4: All properties value of an instance must be immutable according to instance immutablilty rules.
                foreach (var propertyInfo in targetType.GetProperties())
                {
                    object propertyValue;

                    try
                    {
                        propertyValue = propertyInfo.GetValue(target);
                    }
                    catch (TargetParameterCountException t)
                    {
                        // Rule 4a: Exception get_Item methods are validated.
                        if (propertyInfo.GetMethod.Name == "get_Item")
                        {
                            continue;
                        }
                        else
                        {
                            throw new UnableToGetPropertyValueException(propertyInfo, t);
                        }
                    }
#pragma warning disable CA1031 // Do not catch general exception types
                    catch (Exception e)
                    {
                        throw new UnableToGetPropertyValueException(propertyInfo, e);
                    }
#pragma warning restore CA1031 // Do not catch general exception types

                    try
                    {
                        this.Validate(propertyValue, stack);
                    }
                    catch (NotImmutableException n)
                    {
                        throw new InstancePropertyValueNotImmutableException(propertyInfo, n);
                    }
                }

                // Rule 5: Rules 3 & 4 should be validated on all inhereted class.
                targetType = targetType.BaseType;
            }

            return;
        }

        private TypeImmutableValidationResult Validate(Type type, bool isBaseType, List<string> stack)
        {
            // If type has already been checked, or is in the process of being checked skip it.
            var stackName = $"{isBaseType}|{type.FullName}";
            if (stack.Contains(stackName))
            {
                return TypeImmutableValidationResult.IsImmutable;
            }

            stack.Add(stackName);

            // Rule 0: Following types are considered immutable: bool, byte, char, decimal, double, float, int, long, sbyte, short, string, uint, ulong and ushort
            if (this.typesConsideredImmutable.ContainsKey(type))
            {
                return TypeImmutableValidationResult.IsImmutable;
            }

            // Rule 1: Enums are immutable.
            if (type.IsEnum)
            {
                return TypeImmutableValidationResult.IsImmutable;
            }

            // Rule 2: Arrays are muteable.
            if (type.IsArray)
            {
                throw new TypeIsArrayException(type);
            }

            var result = TypeImmutableValidationResult.IsImmutable;

            // Rule 3: Instances of interfaces can be both muttable and immutable.
            if (type.IsInterface)
            {
                result = TypeImmutableValidationResult.MightBeImmutable;
            }

            if (type.IsClass)
            {
                // Rule 4: Class types must be sealed to ensure immutability on type level.
                if (!type.IsSealed)
                {
                    if (!isBaseType)
                    {
                        result = TypeImmutableValidationResult.MightBeImmutable;
                    }
                }

                // Rule 5: Class base types must be immutable for type to be immutable.
                if (type.BaseType != null)
                {
                    try
                    {
                        TypeImmutableValidationResult baseTypeResult = this.Validate(type.BaseType, true, stack);
                        if (baseTypeResult == TypeImmutableValidationResult.MightBeImmutable)
                        {
                            result = TypeImmutableValidationResult.MightBeImmutable;
                        }
                    }
                    catch (NotImmutableException n)
                    {
                        throw new BaseClassNotImmutableException(type.BaseType, type, n);
                    }
                }
            }

            // Interfaces, Struct and Class fields
            foreach (var fieldInfo in GetInstanceFields(type))
            {
                // Rule E1: Ignore if has ImmutableValidatorIgnoreAttribute
                var attr = fieldInfo.GetCustomAttributes(typeof(ImmutableValidatorIgnoreAttribute), false);
                if (attr.Length > 0)
                {
                    continue;
                }

                // Rule 6: Interfaces, structs and classes fields must be readonly.
                if (!fieldInfo.IsInitOnly)
                {
                    throw new FieldIsNotInitOnlyException(type, fieldInfo);
                }

                // Rule 7: Interfaces, structs and classes fields must be immutable.
                try
                {
                    var fieldTypeResult = this.Validate(fieldInfo.FieldType, false, stack);
                    if (fieldTypeResult == TypeImmutableValidationResult.MightBeImmutable)
                    {
                        result = TypeImmutableValidationResult.MightBeImmutable;
                    }
                }
                catch (TypeIsArrayException t)
                {
                    // Rule 7a: Exception to allow collections we allow for a single inner array in MikValSor.Immutable.ImmutableCollection`1.
                    if (type.FullName.StartsWith("MikValSor.Immutable.ImmutableCollection`1[", StringComparison.InvariantCulture) && fieldInfo.Name == "m_array")
                    {
                        // Test element type;
                        var arrayElementTypeResult = this.Validate(fieldInfo.FieldType.GetElementType(), false, stack);
                        if (arrayElementTypeResult == TypeImmutableValidationResult.MightBeImmutable)
                        {
                            result = TypeImmutableValidationResult.MightBeImmutable;
                        }
                    }
                    else
                    {
                        throw new TypeFieldNotImmutableException(fieldInfo, t);
                    }
                }
                catch (NotImmutableException n)
                {
                    throw new TypeFieldNotImmutableException(fieldInfo, n);
                }
            }

            // Interfaces, Struct and Class fields
            foreach (var propertyInfo in type.GetProperties())
            {
                // Rule 8: Interfaces, structs and classes properties cannot have setters.
                if (propertyInfo.CanWrite)
                {
                    throw new PropertyCanWriteException(propertyInfo);
                }

                // Rule 9: Interfaces, structs and classes properties must be immutable.
                try
                {
                    var propertyTypeResult = this.Validate(propertyInfo.PropertyType, false, stack);
                    if (propertyTypeResult == TypeImmutableValidationResult.MightBeImmutable)
                    {
                        result = TypeImmutableValidationResult.MightBeImmutable;
                    }
                }
                catch (NotImmutableException n)
                {
                    throw new TypePropertyNotImmutableException(propertyInfo, n);
                }
            }

            return result;
        }
    }
}
