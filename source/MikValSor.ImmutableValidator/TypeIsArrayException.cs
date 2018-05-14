using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for signaling the type is an array and i there for is mutable.
	/// </summary>
	public sealed class TypeIsArrayException : NotImmutableException
	{
		/// <summary>
		///		Type that is an array.
		/// </summary>
		public readonly Type Type;

		internal TypeIsArrayException(Type type) : base($"Type: {type.FullName}")
		{
			Type = type;
		}
	}
}
