using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorNullTest
	{
		[Test]
		public void IsImmutable_object_null()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = null;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_null()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = null;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

	}
}
