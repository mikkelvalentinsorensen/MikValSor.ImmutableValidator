using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class TypePropertyNotImmutableException : NotImmutableException
	{
		public readonly Type Type;
		public readonly PropertyInfo PropertyInfo;

		internal TypePropertyNotImmutableException(Type type, PropertyInfo propertyInfo, NotImmutableException innerException) : base($"Property: {propertyInfo.Name}, Type: {type.FullName}", innerException)
		{
			Type = type;
			PropertyInfo = propertyInfo;
		}
	}
}
