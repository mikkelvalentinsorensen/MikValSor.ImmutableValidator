using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorStructVariabelsTest
	{
		private struct PrivateStringTestStruct
		{
			private string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private struct PrivateReadonlyStringTestStruct
		{
			private readonly string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateReadonlyStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateReadonlyStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private struct PrivateConstStringTestStruct
		{
			private const string s = "";
		}

		[Test]
		public void IsImmutable_Type_PrivateConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateConstStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateConstStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private struct ProtectedReadonlyStringTestStruct
		{
			private readonly string s;
		}

		[Test]
		public void IsImmutable_Type_ProtectedReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedReadonlyStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedReadonlyStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private struct ProtectedConstStringTestStruct
		{
			private const string s = "";
		}

		[Test]
		public void IsImmutable_Type_ProtectedConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedConstStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedConstStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private struct PublicStringTestStruct
		{
			public string s;
		}

		[Test]
		public void IsImmutable_Type_PublicStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private struct PublicReadonlyStringTestStruct
		{
			public readonly string s;
		}

		[Test]
		public void IsImmutable_Type_PublicReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicReadonlyStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicReadonlyStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicReadonlyStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private struct PublicConstStringTestStruct
		{
			public const string s = "";
		}

		[Test]
		public void IsImmutable_Type_PublicConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicConstStringTestStruct);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicConstStringTestStruct()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicConstStringTestStruct();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
	}
}
