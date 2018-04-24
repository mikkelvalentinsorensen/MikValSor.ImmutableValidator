using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for signaling that property is setable.
	/// </summary>
	public sealed class PropertyCanWriteException : NotImmutableException
	{
		internal PropertyCanWriteException(Type type, PropertyInfo propertyInfo) : base($"Property: {propertyInfo.Name}, Type: {type.FullName}")
		{
			Data.Add("Type", type);
			Data.Add("PropertyInfo", propertyInfo);
		}
	}
}
