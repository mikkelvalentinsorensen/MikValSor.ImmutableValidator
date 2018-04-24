using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorClassTypesTest
	{
		private sealed class PrivateSealedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateSealedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateSealedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		internal sealed class InternalSealedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_InternalSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalSealedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_InternalSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalSealedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		protected sealed class ProtectedSealedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_ProtectedSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedSealedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedSealedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private protected sealed class PrivateProtectedSealedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedSealedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedSealedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		public sealed class PublicSealedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PublicSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicSealedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicSealedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicSealedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private abstract class PrivateAbstractTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateAbstractTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateAbstractTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		internal abstract class InternalAbstractTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_InternalAbstractTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalAbstractTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		protected abstract class ProtectedAbstractTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_ProtectedAbstractTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedAbstractTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private protected abstract class PrivateProtectedAbstractTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedAbstractTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedAbstractTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		public abstract class PublicAbstractTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PublicAbstractTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicAbstractTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private class PrivateTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		[Test]
		public void IsImmutable_object_PrivateTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		internal class InternalTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_InternalTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_InternalTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		protected class ProtectedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_ProtectedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private protected class PrivateProtectedTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		public class PublicTestClass
		{
		}

		[Test]
		public void IsImmutable_Type_PublicTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
	}
}
