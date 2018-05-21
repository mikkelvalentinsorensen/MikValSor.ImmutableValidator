using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorShortTest
	{
		[Test]
		public void IsImmutable_short_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			short target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (short)0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(short);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void EnsureImmutable_object_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (short)0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_short_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			short target = 0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_Type_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(short);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}
