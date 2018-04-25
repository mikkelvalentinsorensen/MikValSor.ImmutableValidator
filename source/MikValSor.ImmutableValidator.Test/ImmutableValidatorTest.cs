using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorTest
	{
		[Test]
		public void ImmutableValidator_construct()
		{
			//Act
			new ImmutableValidator();

			//Assert
			Assert.Pass();
		}
	}
}
