using System.Reflection;

namespace MikValSor.Immutable
{
    public class InstanceFieldValueNotImmutableException : NotImmutableException
	{
		public readonly object Instance;
		public readonly FieldInfo FieldInfo;
		public readonly object FieldValue;

#warning fix message
		internal InstanceFieldValueNotImmutableException(object instance, FieldInfo fieldInfo, object fieldValue, NotImmutableException innerException) : base("", innerException)
		{
			Instance = instance;
			FieldInfo = fieldInfo;
			FieldValue = fieldValue;
		}
	}
}
