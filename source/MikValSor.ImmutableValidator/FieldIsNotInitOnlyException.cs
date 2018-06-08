using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for cases where class fields are setable only on initialization of class.
	/// </summary>
	[Serializable]
	public sealed class FieldIsNotInitOnlyException : NotImmutableException
	{
		/// <summary>
		///		Constructs exception for cases where fields are always setable.
		/// </summary>
		/// <param name="type">
		///		Type of the object containing the field.
		/// </param>
		/// <param name="fieldInfo">
		///		Field infor mation of the always setable field.
		/// </param>
		public FieldIsNotInitOnlyException(Type type, FieldInfo fieldInfo) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}")
		{
		}

		/// <summary>
		///  Initializes a new instance of the class.
		/// </summary>
		public FieldIsNotInitOnlyException()
		{
		}

		/// <summary>
		///		Initializes a new instance of the System.Exception class with a specified error message.
		/// </summary>
		/// <param name="message">
		///		The message that describes the error.
		/// </param>
		public FieldIsNotInitOnlyException(string message) : base(message)
		{
		}

		/// <summary>
		///		Initializes a new instance of the class with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">
		///		The error message that explains the reason for the exception.
		/// </param>
		/// <param name="innerException">
		///		The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.
		/// </param>
		public FieldIsNotInitOnlyException(string message, Exception innerException) : base(message, innerException)
		{
		}

		private FieldIsNotInitOnlyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
