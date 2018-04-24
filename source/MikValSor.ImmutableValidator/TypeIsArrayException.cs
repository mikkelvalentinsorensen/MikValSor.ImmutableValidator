using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for signaling the type is an array and i there for not immutable.
	/// </summary>
	public sealed class TypeIsArrayException : NotImmutableException
	{
		internal TypeIsArrayException(Type type) : base($"Type: {type.FullName}")
		{
			Data.Add("Type", type);
		}
	}
}
