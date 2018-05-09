using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	internal class UnableToGetPropertyValueException : NotImmutableException
	{
#warning fix message
		public UnableToGetPropertyValueException(object target, PropertyInfo propertyInfo, Exception e)
		{<
		}
	}
}