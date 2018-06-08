using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception used to signal when the property of a type is not immutable.
	/// </summary>
	[Serializable]
	public class TypePropertyNotImmutableException : NotImmutableException
	{
		public TypePropertyNotImmutableException(Type type, PropertyInfo propertyInfo, NotImmutableException innerException) : base($"Property: {propertyInfo.Name}, Type: {type.FullName}", innerException)
		{
		}

		/// <summary>
		///		Initializes a new instance of the class.
		/// </summary>
		public TypePropertyNotImmutableException()
		{
		}

		/// <summary>
		///		Initializes a new instance of the System.Exception class with a specified error message.
		/// </summary>
		/// <param name="message">
		///		The message that describes the error.
		/// </param>
		public TypePropertyNotImmutableException(string message) : base(message)
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
		public TypePropertyNotImmutableException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>
		///		Initializes a new instance of the class with serialized data.
		/// </summary>
		/// <param name="info">
		///		The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.
		/// </param>
		/// <param name="context">
		///		The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.
		/// </param>
		/// <exception cref="System.ArgumentNullException">
		///		The info parameter is null.
		/// </exception>
		/// <exception cref="SerializationException">
		///		The class name is null or System.Exception.HResult is zero (0).
		/// </exception>
		protected TypePropertyNotImmutableException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
