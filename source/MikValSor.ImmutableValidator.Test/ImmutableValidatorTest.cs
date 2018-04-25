using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorTest
	{
		[Test]
		public void IsImmutable_construct()
		{
			//Act
			new ImmutableValidator();

			//Assert
			Assert.Pass();
		}
	}
}
