using System;

namespace MikValSor.Immutable
{
    public class TypeDoesNotGuaranteeImmutabilityException : NotImmutableException
    {
		public readonly Type Type;
		internal TypeDoesNotGuaranteeImmutabilityException(Type type) : base($"Type {type.FullName} does not guarantee immutability, instances of type must be validated to ensure immutability.")
		{
			Type = type;
		}
	}
}
