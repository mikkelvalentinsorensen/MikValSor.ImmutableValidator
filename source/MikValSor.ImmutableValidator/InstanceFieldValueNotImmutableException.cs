using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class used to signal when classes field value is set to a value that is mutable.
	/// </summary>
    public class InstanceFieldValueNotImmutableException : NotImmutableException
	{
		/// <summary>
		///		Instance containing the field with mutable value.
		/// </summary>
		public readonly object Instance;

		/// <summary>
		///		Field information of the field that contains the mutable value.
		/// </summary>
		public readonly FieldInfo FieldInfo;

		/// <summary>
		///		The value of that caused the exception.
		/// </summary>
		public readonly object FieldValue;

		internal InstanceFieldValueNotImmutableException(object instance, FieldInfo fieldInfo, object fieldValue, NotImmutableException innerException) : base($"Instance of type {instance.GetType().FullName} field {fieldInfo.Name} is mutable.", innerException)
		{
			Instance = instance;
			FieldInfo = fieldInfo;
			FieldValue = fieldValue;
		}
	}
}
