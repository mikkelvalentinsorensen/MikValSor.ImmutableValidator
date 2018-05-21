using System;

namespace MikValSor.Immutable.Extensions
{
    public static class ImmutableValidatorExtender
    {

		/// <summary>
		///		Checks if target object is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted object for immutable validation.
		/// </param>
		/// <returns>
		///		Returns True if object is immutable.
		/// </returns>
		public static bool IsImmutable(this object instance)
		{
			return ImmutableValidator.Instance.IsImmutable(instance);
		}


		/// <summary>
		///		int is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted int for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("int are immutable, so do not validate for this")]
		public static bool IsImmutable(this int instance)
		{
			return true;
		}

		/// <summary>
		///		bool is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted bool for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("bool are immutable, so do not validate for this")]
		public static bool IsImmutable(this bool instance)
		{
			return true;
		}

		/// <summary>
		///		byte is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted byte for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("byte are immutable, so do not validate for this")]
		public static bool IsImmutable(this byte instance)
		{
			return true;
		}

		/// <summary>
		///		char is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted char for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("char are immutable, so do not validate for this")]
		public static bool IsImmutable(this char instance)
		{
			return true;
		}

		/// <summary>
		///		decimal is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted decimal for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("decimal are immutable, so do not validate for this")]
		public static bool IsImmutable(this decimal instance)
		{
			return true;
		}

		/// <summary>
		///		float is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted float for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("float are immutable, so do not validate for this")]
		public static bool IsImmutable(this float instance)
		{
			return true;
		}

		/// <summary>
		///		long is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted long for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("long are immutable, so do not validate for this")]
		public static bool IsImmutable(this long instance)
		{
			return true;
		}

		/// <summary>
		///		sbyte is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted sbyte for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("sbyte are immutable, so do not validate for this")]
		public static bool IsImmutable(this sbyte instance)
		{
			return true;
		}

		/// <summary>
		///		short is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted short for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("short are immutable, so do not validate for this")]
		public static bool IsImmutable(this short instance)
		{
			return true;
		}

		/// <summary>
		///		string is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted string for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("string are immutable, so do not validate for this")]
		public static bool IsImmutable(this string instance)
		{
			return true;
		}

		/// <summary>
		///		uint is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted uint for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("uint are immutable, so do not validate for this")]
		public static bool IsImmutable(this uint instance)
		{
			return true;
		}

		/// <summary>
		///		ulong is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted ulong for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("ulong are immutable, so do not validate for this")]
		public static bool IsImmutable(this ulong instance)
		{
			return true;
		}

		/// <summary>
		///		ushort is immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted ushort for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("ushort are immutable, so do not validate for this")]
		public static bool IsImmutable(this ushort instance)
		{
			return true;
		}

		/// <summary>
		///		Enums are immutable.
		/// </summary>
		/// <param name="instance">
		///		Targeted enum for immutable validation.
		/// </param>
		/// <returns>
		///		true.
		/// </returns>
		[Obsolete("Enums are immutable, so do not validate for this")]
		public static bool IsImmutable(this Enum instance)
		{
			return true;
		}

		static void Aa()
		{
			int[] i = null;
			TypeImmutableValidationResult.IsImmutable.IsImmutable();
		}
    }
}
