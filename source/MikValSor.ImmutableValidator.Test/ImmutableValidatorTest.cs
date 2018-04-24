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

		[Test]
		public void IsImmutable_int_1()
		{
			//Arrange
			var validator = new ImmutableValidator();
			int target = 1;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_object()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new object();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_object()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(object);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_typeofinterface_IDisposable()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(System.IDisposable);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
	}
}
