using System;
using System.Collections.Generic;
using System.Text;

namespace MikValSor.Immutable
{
    public class TypeDoesNotGuaranteeImmutabilityException : NotImmutableException
    {
		public TypeDoesNotGuaranteeImmutabilityException(Type type) : base($"Type {type.FullName} does not guarantee immutability, instances of type must be validated to ensure immutability.")
		{
		}
	}
}
