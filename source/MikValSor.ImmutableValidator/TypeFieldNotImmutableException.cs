using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class TypeFieldNotImmutableException : NotImmutableException
	{
		public TypeFieldNotImmutableException(Type type, FieldInfo fieldInfo, NotImmutableException innerException) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
		}
	}
}
