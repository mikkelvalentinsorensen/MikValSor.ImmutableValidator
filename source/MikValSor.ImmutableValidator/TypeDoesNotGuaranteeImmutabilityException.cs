using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception used to signal that a the type alone does not guarantee that an instance of the class is mutable. The instance of the class would have to be validated to ensure imutablility.
	/// </summary>
	public class TypeDoesNotGuaranteeImmutabilityException : NotImmutableException
    {
		/// <summary>
		///		Contains type that does not guarantee immutability.
		/// </summary>
		public readonly Type Type;

		internal TypeDoesNotGuaranteeImmutabilityException(Type type) : base($"Type {type.FullName} does not guarantee immutability, instances of type must be validated to ensure immutability.")
		{
			Type = type;
		}
	}
}
