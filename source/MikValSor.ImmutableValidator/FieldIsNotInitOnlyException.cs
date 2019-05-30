// <copyright file="FieldIsNotInitOnlyException.cs">
// Copyright (C) 2018-2019 Mikkel Valentin Sorensen
//
// This file is part of MikValSor.ImmutableValidator.
//
// MikValSor.ImmutableValidator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// MikValSor.ImmutableValidator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with MikValSor.ImmutableValidator. If not, see http://www.gnu.org/licenses/.
// </copyright>
namespace MikValSor.Immutable
{
    using System;
    using System.Reflection;
    using System.Runtime.Serialization;

    /// <summary>Exception class for cases where class fields are setable only on initialization of class.</summary>
    [Serializable]
    public sealed class FieldIsNotInitOnlyException : NotImmutableException
    {
        /// <summary>Initializes a new instance of the <see cref="FieldIsNotInitOnlyException"/> class.</summary>
        /// <param name="type">Type of the object containing the field.</param>
        /// <param name="fieldInfo">Field infor mation of the always setable field.</param>
        public FieldIsNotInitOnlyException(Type type, FieldInfo fieldInfo)
            : base($"Field: {fieldInfo.Name}, Type: {type.FullName}")
        {
        }

        /// <summary>Initializes a new instance of the <see cref="FieldIsNotInitOnlyException"/> class.</summary>
        public FieldIsNotInitOnlyException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="FieldIsNotInitOnlyException"/> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public FieldIsNotInitOnlyException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="FieldIsNotInitOnlyException"/> class.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public FieldIsNotInitOnlyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        private FieldIsNotInitOnlyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
