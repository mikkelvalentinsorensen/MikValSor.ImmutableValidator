using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorClassVariabelsTest
	{
		private sealed class PrivateStringTestClass
		{
			private string s;
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

		[Test]
		public void IsImmutable_object_PrivateStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PrivateReadonlyStringTestClass
		{
			private readonly string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateReadonlyStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateReadonlyStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private sealed class PrivateConstStringTestClass
		{
			private const string s = "";
		}

		[Test]
		public void IsImmutable_Type_PrivateConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateConstStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateConstStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class ProtectedStringTestClass
		{
			protected string s;
		}

		[Test]
		public void IsImmutable_Type_ProtectedStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class ProtectedReadonlyStringTestClass
		{
			private readonly string s;
		}

		[Test]
		public void IsImmutable_Type_ProtectedReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedReadonlyStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedReadonlyStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private sealed class ProtectedConstStringTestClass
		{
			private const string s = "";
		}

		[Test]
		public void IsImmutable_Type_ProtectedConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedConstStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedConstStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class PrivateProtectedStringTestClass
		{
			private protected string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PrivateProtectedReadonlyStringTestClass
		{
			private protected readonly string s;
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedReadonlyStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedReadonlyStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private sealed class PrivateProtectedConstStringTestClass
		{
			private protected const string s = "";
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedConstStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedConstStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class PublicStringTestClass
		{
			public string s;
		}

		[Test]
		public void IsImmutable_Type_PublicStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PublicReadonlyStringTestClass
		{
			public readonly string s;
		}

		[Test]
		public void IsImmutable_Type_PublicReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicReadonlyStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicReadonlyStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicReadonlyStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		private sealed class PublicConstStringTestClass
		{
			public const string s = "";
		}

		[Test]
		public void IsImmutable_Type_PublicConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicConstStringTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicConstStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicConstStringTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
	}
}
