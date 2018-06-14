using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Attribute used to signal that ImmutableValidator should skip field on validation
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public class ImmutableValidatorIgnoreAttribute : Attribute
	{
		/// <summary>
		///		Attribute used to signal that ImmutableValidator should skip field on validation
		/// </summary>
		public ImmutableValidatorIgnoreAttribute()
		{
		}
	}
}