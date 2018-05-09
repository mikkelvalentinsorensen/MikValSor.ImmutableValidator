using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class UnableToGetFieldValueException : NotImmutableException
	{
		public readonly object Instance;
		public readonly FieldInfo FieldInfo;

#warning fix message
		internal UnableToGetFieldValueException(object instance, FieldInfo fieldInfo, Exception innerException) : base("", innerException)
		{
			Instance = instance;
			FieldInfo = fieldInfo;
		}
	}
}
