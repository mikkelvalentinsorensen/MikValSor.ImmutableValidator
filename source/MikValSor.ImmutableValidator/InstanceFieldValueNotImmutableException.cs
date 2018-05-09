using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class InstanceFieldValueNotImmutableException : NotImmutableException
	{
#warning fix message
		public InstanceFieldValueNotImmutableException(object obj, FieldInfo fieldInfo, object fieldValue, NotImmutableException innerException) : base("", innerException)
		{
		}
	}
}
