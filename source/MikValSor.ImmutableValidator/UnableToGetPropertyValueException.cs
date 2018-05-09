using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	internal class UnableToGetPropertyValueException : NotImmutableException
	{
		public object Instance;
		public PropertyInfo PropertyInfo;

#warning fix message
		internal UnableToGetPropertyValueException(object instance, PropertyInfo propertyInfo, Exception e) : base($"", e)
		{
			Instance = instance;
			PropertyInfo = propertyInfo;
		}
	}
}