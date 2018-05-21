﻿using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorLongTest
	{
		[Test]
		public void IsImmutable_long_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			long target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (long)0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(long);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void EnsureImmutable_object_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = (long)0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_long_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			long target = 0;

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}

		[Test]
		public void EnsureImmutable_Type_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(long);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}