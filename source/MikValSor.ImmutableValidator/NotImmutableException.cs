using System;

namespace MikValSor.Immutable
{
	/// <summary>
	///		Base class for exceptions throwen when classes are being validatet for immutablilty.
	/// </summary>
	public abstract class NotImmutableException : Exception
	{
		internal NotImmutableException(string message) : base(message)
		{
		}

		internal NotImmutableException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
