using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class ClassPropertyNotImmutableException : NotImmutableException
	{
		public ClassPropertyNotImmutableException(Type type, PropertyInfo fieldInfo, NotImmutableException innerException) : base($"Property: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
		}
	}
}
