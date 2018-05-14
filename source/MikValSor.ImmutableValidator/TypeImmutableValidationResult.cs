namespace MikValSor.Immutable
{
	/// <summary>
	///		Emun class used to reply immutablilty state of types.
	/// </summary>
    public enum TypeImmutableValidationResult
    {
		/// <summary>
		///		Signals that type guarantee immutablilty.
		/// </summary>
		IsImmutable = 0,

		/// <summary>
		///		Signals that type does not guarantee immutability, but verifying instance will reveal if it is immutable.
		/// </summary>
		MightBeImmutable = 1
    }
}
