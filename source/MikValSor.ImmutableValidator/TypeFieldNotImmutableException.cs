using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class used for signaling when types are mutable due to a field member being mutable.
	/// </summary>
    public class TypeFieldNotImmutableException : NotImmutableException
	{
		/// <summary>
		///		Type containing the field that is mutable.
		/// </summary>
		public readonly Type Type;

		/// <summary>
		///		Field information of the field that is mutable.
		/// </summary>
		public readonly FieldInfo FieldInfo;

		internal TypeFieldNotImmutableException(Type type, FieldInfo fieldInfo, NotImmutableException innerException) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
			Type = type;
			FieldInfo = fieldInfo;
		}
	}
}
