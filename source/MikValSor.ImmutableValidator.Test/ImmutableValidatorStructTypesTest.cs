using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorStructTypesTest
	{
		private struct PrivateTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private readonly struct PrivateReadonlyTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateReadonlyTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateReadonlyTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private protected struct PrivateProtectedTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private protected readonly struct PrivateProtectedReadonlyTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedReadonlyTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedReadonlyTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		protected struct ProtectedTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_ProtectedTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		protected readonly struct ProtectedReadonlyTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_ProtectedReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedReadonlyTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedReadonlyTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		internal struct InternalTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_InternalTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_InternalTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		internal readonly struct InternalReadonlyTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_InternalReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalReadonlyTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_InternalReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalReadonlyTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}


		public struct PublicTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PublicTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		public readonly struct PublicReadonlyTestStruct
		{
		}

		[Test]
		public void IsImmutable_Type_PublicReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicReadonlyTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicReadonlyTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicReadonlyTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
	}
}
