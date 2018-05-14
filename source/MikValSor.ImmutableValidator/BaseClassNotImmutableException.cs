using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for cases where the base class is the course for class that are mutable.
	/// </summary>
	public class BaseClassNotImmutableException : NotImmutableException
	{
		/// <summary>
		///		Containes the type of the base class that mutable.
		/// </summary>
		public readonly Type BaseType;

		/// <summary>
		///		Containes the type that be derived from the mutable class.
		/// </summary>
		public readonly Type DerivedType;

		internal BaseClassNotImmutableException(Type baseType, Type derivedType, NotImmutableException innerException) : base($"Type {derivedType.FullName} because base inherited base class {baseType.FullName} was not immutable.", innerException)
		{
			BaseType = baseType;
			DerivedType = derivedType;
		}
	}
}
