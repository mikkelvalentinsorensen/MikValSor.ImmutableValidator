using System;

namespace MikValSor.Immutable
{
    public class BaseClassNotImmutableException : NotImmutableException
	{
		public readonly Type BaseType;
		public readonly Type DerivedType;

		internal BaseClassNotImmutableException(Type baseType, Type derivedType, NotImmutableException innerException) : base($"Type {derivedType.FullName} because base inherited base class {baseType.FullName} was not immutable.", innerException)
		{
			BaseType = baseType;
			DerivedType = derivedType;
		}

	}
}
