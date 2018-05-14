using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception used to signal when the property of a type is not immutable.
	/// </summary>
    public class TypePropertyNotImmutableException : NotImmutableException
	{
		/// <summary>
		///		The type that contains the propperty that is not immutable.
		/// </summary>
		public readonly Type Type;

		/// <summary>
		///		The property information of the mutable property.
		/// </summary>
		public readonly PropertyInfo PropertyInfo;

		internal TypePropertyNotImmutableException(Type type, PropertyInfo propertyInfo, NotImmutableException innerException) : base($"Property: {propertyInfo.Name}, Type: {type.FullName}", innerException)
		{
			Type = type;
			PropertyInfo = propertyInfo;
		}
	}
}
