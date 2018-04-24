﻿using System;
using System.Reflection;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for cases where class fields are setable only on initialization of class.
	/// </summary>
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
		internal FieldIsNotInitOnlyException(Type type, FieldInfo fieldInfo) : base($"Field: {fieldInfo.Name}, Type: {type.FullName}")
		{
			Data.Add("Type", type);
			Data.Add("FieldInfo", fieldInfo);
		}
	}
}
