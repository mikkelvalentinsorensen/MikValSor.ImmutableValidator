using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Exception class for cases where classes are not sealed.
	/// </summary>
	public sealed class ClassNotSealedException : NotImmutableException
	{
		public readonly Type Type;

		/// <summary>
		///		Constructs class not sealed exception for given type.
		/// </summary>
		/// <param name="type">
		///		The type of the class that is not sealed.
		/// </param>
		internal ClassNotSealedException(Type type) : base($"Type: {type.FullName}")
		{
			Type = type;
		}
	}
}
