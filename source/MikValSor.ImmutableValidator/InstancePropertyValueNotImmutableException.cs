using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class used to signal when classes property value is set to a value that is mutable.
	/// </summary>
	public class InstancePropertyValueNotImmutableException : NotImplementedException
	{
		/// <summary>
		///		Instance containing the property with mutable value.
		/// </summary>
		public object Instance;

		/// <summary>
		///		Property information of the property that contains the mutable value.
		/// </summary>
		public PropertyInfo PropertyInfo;

		/// <summary>
		///		The value of that caused the exception.
		/// </summary>
		public object PropertyValue;

		internal InstancePropertyValueNotImmutableException(object instance, PropertyInfo propertyInfo, object propertyValue, NotImmutableException n) : base($"Instance of type {instance.GetType().FullName} property {propertyInfo.Name} is mutable.", n)
		{
			Instance = instance;
			PropertyInfo = propertyInfo;
			PropertyValue = propertyValue;
		}
	}
}