using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatoyReuseTest
	{
		private sealed class WrapTestObject
		{
			public readonly object Value;
			public WrapTestObject(object value)
			{
				Value = value;
			}
		}

		[Test]
		public void TestMethod()
		{
			//Arrange
			var validator = new ImmutableValidator();
			var object1 = new WrapTestObject(new object());
			var object2 = new WrapTestObject(new object[1] { 1 });

			//Act
			var result1 = validator.IsImmutable(object1);
			var result2 = validator.IsImmutable(object1);

			//Assert
			Assert.IsTrue(result1);
			Assert.IsFalse(result2);
		}
	}
}
