using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	class ImmutableValidatorIgnoreAttributeTest
	{
		private sealed class PrivateStringTestClass
		{
			string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PrivateStringWithAttributeTestClass
		{
			[ImmutableValidatorIgnore]
			string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateStringWithAttributeTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringWithAttributeTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
	}
}
