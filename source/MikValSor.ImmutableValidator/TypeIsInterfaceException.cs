using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception signaling that validated type is an interface.
	/// </summary>
	public sealed class TypeIsInterfaceException : NotImmutableException
	{
		public readonly Type Type;

		internal TypeIsInterfaceException(Type type) : base($"Type: {type.FullName}")
		{
			Type = type;
		}
	}
}
