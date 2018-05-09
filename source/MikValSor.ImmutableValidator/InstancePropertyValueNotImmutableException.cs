using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	internal class InstancePropertyValueNotImmutableException : NotImplementedException
	{
		public object Instance;
		public PropertyInfo PropertyInfo;
		public object PropertyValue;


#warning fix message
		internal InstancePropertyValueNotImmutableException(object instance, PropertyInfo propertyInfo, object propertyValue, NotImmutableException n) : base("", n)
		{
			Instance = instance;
			PropertyInfo = propertyInfo;
			PropertyValue = propertyValue;
		}
	}
}