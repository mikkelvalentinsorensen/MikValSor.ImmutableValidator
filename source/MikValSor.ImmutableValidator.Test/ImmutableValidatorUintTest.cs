using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorUintTest
	{
		[Test]
		public void IsImmutable_uint_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			uint target = 0;

			//Act
#pragma warning disable CS0618 // Type or member is obsolete
			var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (uint)0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(uint);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void EnsureImmutable_object_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (uint)0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_uint_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			uint target = 0;

			//Act
#pragma warning disable CS0618 // Type or member is obsolete
			validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

			//Assert
		}

		[Test]
		public void EnsureImmutable_Type_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(uint);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}
