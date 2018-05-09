using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MikValSor.Immutable
{
    public class UnableToGetFieldValueException : NotImmutableException
	{
#warning fix message
		public UnableToGetFieldValueException(object obj, FieldInfo fieldInfo, Exception innerException) : base("", innerException)
		{
		}
	}
}
