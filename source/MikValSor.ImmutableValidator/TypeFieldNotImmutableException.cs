using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class TypeFieldNotImmutableException : NotImmutableException
	{
		public readonly Type Type;
		public readonly FieldInfo FieldInfo;

		internal TypeFieldNotImmutableException(Type type, FieldInfo fieldInfo, NotImmutableException innerException) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
			Type = type;
			FieldInfo = fieldInfo;
		}
	}
}
