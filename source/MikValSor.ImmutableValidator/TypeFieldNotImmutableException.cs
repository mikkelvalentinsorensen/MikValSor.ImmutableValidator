// <copyright file="TypeFieldNotImmutableException.cs">
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

    /// <summary>Exception class used for signaling when types are mutable due to a field member being mutable.</summary>
    [Serializable]
    public class TypeFieldNotImmutableException : NotImmutableException
    {
        /// <summary>Initializes a new instance of the <see cref="TypeFieldNotImmutableException"/> class.</summary>
        public TypeFieldNotImmutableException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypeFieldNotImmutableException"/> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public TypeFieldNotImmutableException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypeFieldNotImmutableException"/> class.</summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public TypeFieldNotImmutableException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypeFieldNotImmutableException"/> class.</summary>
        /// <param name="fieldInfo">Field of that coused the not immutable exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        internal TypeFieldNotImmutableException(FieldInfo fieldInfo, NotImmutableException innerException)
            : base($"Field: {fieldInfo.Name}, Type: {fieldInfo.DeclaringType.FullName}", innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="TypeFieldNotImmutableException"/> class.</summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The info parameter is null.</exception>
        /// <exception cref="SerializationException">The class name is null or <see cref="System.Exception.HResult"/> is zero (0).</exception>
        protected TypeFieldNotImmutableException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
