using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception signaling that validated type is an interface.
	/// </summary>
	public sealed class TypeIsInterfaceException : NotImmutableException
	{
		internal TypeIsInterfaceException(Type type) : base($"Type: {type.FullName}")
		{
			Data.Add("Type", type);
		}
	}
}
