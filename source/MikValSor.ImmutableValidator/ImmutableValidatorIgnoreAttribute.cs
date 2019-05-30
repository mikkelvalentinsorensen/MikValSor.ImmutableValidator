// <copyright file="ImmutableValidatorIgnoreAttribute.cs">
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

    /// <summary>Attribute used to signal that ImmutableValidator should skip field on validation</summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false)]
    public class ImmutableValidatorIgnoreAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the <see cref="ImmutableValidatorIgnoreAttribute"/> class.</summary>
        public ImmutableValidatorIgnoreAttribute()
        {
        }
    }
}