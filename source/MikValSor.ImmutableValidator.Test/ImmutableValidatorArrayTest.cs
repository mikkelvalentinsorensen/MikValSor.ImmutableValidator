using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorArrayTest
	{
		[Test]
		public void IsImmutable_array_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			string[] target = new string[1];

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new string[1]; ;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_Type_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(string[]);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void EnsureImmutable_object_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new string[1]; ;

			//Act
			try
			{
				validator.EnsureImmutable(target);
			}

			//Assert
			catch (NotImmutableException)
			{
				Assert.Pass();
			}
			Assert.Fail();
		}

		[Test]
		public void EnsureImmutable_array_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			string[] target = new string[1]; ;

			//Act
			try
			{
				validator.EnsureImmutable(target);
			}

			//Assert
			catch (NotImmutableException)
			{
				Assert.Pass();
			}
			Assert.Fail();
		}

		[Test]
		public void EnsureImmutable_Type_array()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(string[]);

			//Act
			try
			{
				validator.EnsureImmutable(target);
			}

			//Assert
			catch (NotImmutableException)
			{
				Assert.Pass();
			}
			Assert.Fail();
		}
	}
}
