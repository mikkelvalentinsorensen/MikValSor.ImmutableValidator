﻿using System;
using System.Reflection;

namespace MikValSor.Immutable
{
    public class TypePropertyNotImmutableException : NotImmutableException
	{
		public TypePropertyNotImmutableException(Type type, PropertyInfo fieldInfo, NotImmutableException innerException) : base($"Property: {fieldInfo.Name}, Type: {type.FullName}", innerException)
		{
		}
	}
}
