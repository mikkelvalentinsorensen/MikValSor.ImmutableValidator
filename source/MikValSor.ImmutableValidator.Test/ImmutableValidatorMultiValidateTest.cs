using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorMultiValidateTest
	{
		[Test]
		public void ImmutableValidator_object_StringAndStringArray()
		{
			var validator =	new ImmutableValidator();
			object sArray = new string[0];
			object s = string.Empty;

			//Act
			var s1 = validator.IsImmutable(s);
			var sArray1 = validator.IsImmutable(sArray);
			var s2 = validator.IsImmutable(s);
			var sArray2 = validator.IsImmutable(sArray);

			//Assert
			Assert.IsTrue(s1);
			Assert.IsFalse(sArray1);
			Assert.IsTrue(s2);
			Assert.IsFalse(sArray2);
		}
	}
}
