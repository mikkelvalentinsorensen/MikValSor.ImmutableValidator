using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class ClassFieldNotImmutableException : NotImmutableException
	{
		public ClassFieldNotImmutableException(Type type, FieldInfo fieldInfo, NotImmutableException innerException) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
		}
	}
}
