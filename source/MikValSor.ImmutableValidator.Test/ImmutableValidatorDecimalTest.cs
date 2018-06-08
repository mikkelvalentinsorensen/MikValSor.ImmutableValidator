using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorDecimalTest
	{
		[Test]
		public void IsImmutable_decimal_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			decimal target = 0;

			//Act
#pragma warning disable CS0618 // Type or member is obsolete
			var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (decimal)0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(decimal);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void EnsureImmutable_object_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (decimal)0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_decimal_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			decimal target = 0;

			//Act
#pragma warning disable CS0618 // Type or member is obsolete
			validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

			//Assert
		}

		[Test]
		public void EnsureImmutable_Type_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(decimal);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}
