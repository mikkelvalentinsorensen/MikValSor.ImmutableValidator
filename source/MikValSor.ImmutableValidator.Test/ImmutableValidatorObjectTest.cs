using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorObjectTest
	{
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
	}
}
