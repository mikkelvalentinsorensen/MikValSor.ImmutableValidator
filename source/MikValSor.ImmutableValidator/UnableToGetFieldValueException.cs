using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class used for signaling that instance validation feiled due to not being able to get value of field.
	/// </summary>
    public class UnableToGetFieldValueException : NotImmutableException
	{
		/// <summary>
		///		Instance containing field.
		/// </summary>
		public readonly object Instance;

		/// <summary>
		///		Field information that was unable to get value.
		/// </summary>
		public readonly FieldInfo FieldInfo;

		internal UnableToGetFieldValueException(object instance, FieldInfo fieldInfo, Exception innerException) : base($"Unable to get value of instance {instance.GetType().FullName} field {fieldInfo.Name}.", innerException)
		{
			Instance = instance;
			FieldInfo = fieldInfo;
		}
	}
}
