// <copyright file="ImmutableValidatorExtender.cs">
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
namespace MikValSor.Immutable.Extensions
{
    using System;

    /// <summary>Immutable validator extensions methods.</summary>
    public static class ImmutableValidatorExtender
    {
        /// <summary>Checks if target <see cref="object"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="object"/> for immutable validation.</param>
        /// <returns>Returns true if object is immutable.</returns>
        public static bool IsImmutable(this object instance) => ImmutableValidator.Instance.IsImmutable(instance);

        /// <summary><see cref="int"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="int"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("int are immutable, so do not validate for this")]
        public static bool IsImmutable(this int instance) => true;

        /// <summary><see cref="bool"/> is immutable.</summary>
        /// <param name="instance">Targeted bool for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("bool are immutable, so do not validate for this")]
        public static bool IsImmutable(this bool instance) => true;

        /// <summary><see cref="byte"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="byte"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("byte are immutable, so do not validate for this")]
        public static bool IsImmutable(this byte instance) => true;

        /// <summary><see cref="char"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="char"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("char are immutable, so do not validate for this")]
        public static bool IsImmutable(this char instance) => true;

        /// <summary><see cref="decimal"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="decimal"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("decimal are immutable, so do not validate for this")]
        public static bool IsImmutable(this decimal instance) => true;

        /// <summary><see cref="float"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="float"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("float are immutable, so do not validate for this")]
        public static bool IsImmutable(this float instance) => true;

        /// <summary><see cref="long"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="long"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("long are immutable, so do not validate for this")]
        public static bool IsImmutable(this long instance) => true;

        /// <summary><see cref="sbyte"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="sbyte"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("sbyte are immutable, so do not validate for this")]
        public static bool IsImmutable(this sbyte instance) => true;

        /// <summary><see cref="short"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="short"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("short are immutable, so do not validate for this")]
        public static bool IsImmutable(this short instance) => true;

        /// <summary><see cref="string"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="string"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("string are immutable, so do not validate for this")]
        public static bool IsImmutable(this string instance) => true;

        /// <summary><see cref="uint"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="uint"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("uint are immutable, so do not validate for this")]
        public static bool IsImmutable(this uint instance) => true;

        /// <summary><see cref="ulong"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="ulong"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("ulong are immutable, so do not validate for this")]
        public static bool IsImmutable(this ulong instance) => true;

        /// <summary><see cref="ushort"/> is immutable.</summary>
        /// <param name="instance">Targeted <see cref="ushort"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("ushort are immutable, so do not validate for this")]
        public static bool IsImmutable(this ushort instance) => true;

        /// <summary><see cref="Enum"/> are immutable.</summary>
        /// <param name="instance">Targeted <see cref="Enum"/> for immutable validation.</param>
        /// <returns>true.</returns>
        [Obsolete("Enums are immutable, so do not validate for this")]
        public static bool IsImmutable(this Enum instance) => true;
    }
}
