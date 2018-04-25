using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorInterfaceTest
	{
		private class IDisposableTestClass : System.IDisposable
		{
			public void Dispose()
			{
				throw new System.NotImplementedException();
			}
		}

		[Test]
		public void IsImmutable_object_IDisposable()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.IDisposable target = new IDisposableTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_IDisposable()
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
