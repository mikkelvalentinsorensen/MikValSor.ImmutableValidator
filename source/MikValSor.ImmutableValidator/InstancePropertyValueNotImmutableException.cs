using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace MikValSor.Immutable
{
	[Serializable]
	internal class InstancePropertyValueNotImmutableException : Exception
	{
		private object target;
		private PropertyInfo propertyInfo;
		private object propertyValue;
		private NotImmutableException n;

		public InstancePropertyValueNotImmutableException()
		{
		}

		public InstancePropertyValueNotImmutableException(string message) : base(message)
		{
		}

		public InstancePropertyValueNotImmutableException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public InstancePropertyValueNotImmutableException(object target, PropertyInfo propertyInfo, object propertyValue, NotImmutableException n)
		{
			this.target = target;
			this.propertyInfo = propertyInfo;
			this.propertyValue = propertyValue;
			this.n = n;
		}

		protected InstancePropertyValueNotImmutableException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}