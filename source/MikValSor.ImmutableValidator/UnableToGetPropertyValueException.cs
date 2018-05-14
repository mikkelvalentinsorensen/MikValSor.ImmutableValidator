using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class used for signaling that instance validation feiled due to not being able to get value of property.
	/// </summary>
	internal class UnableToGetPropertyValueException : NotImmutableException
	{
		/// <summary>
		///		Instance containing property.
		/// </summary>
		public object Instance;

		/// <summary>
		///		Property information that was unable to get value.
		/// </summary>
		public PropertyInfo PropertyInfo;

		internal UnableToGetPropertyValueException(object instance, PropertyInfo propertyInfo, Exception e) : base($"Unable to get value of instance {instance.GetType().FullName} property {propertyInfo.Name}.", e)
		{
			Instance = instance;
			PropertyInfo = propertyInfo;
		}
	}
}