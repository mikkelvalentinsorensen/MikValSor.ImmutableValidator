using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorClassFieldArraysTest
	{
		private sealed class PrivateStringArrayGetTestClass
		{
			private string[] s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringArrayGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringArrayGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PrivateStringArrayGetSetTestClass
		{
			private string[] s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringArrayGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringArrayGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class ProtectedStringArrayGetTestClass
		{
			protected string[] s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedStringArrayGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedStringArrayGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class ProtectedStringArrayGetSetTestClass
		{
			protected string[] s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_ProtectedStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedStringArrayGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedStringArrayGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class PrivateProtectedStringArrayGetTestClass
		{
			private protected string[] s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedStringArrayGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedStringArrayGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PrivateProtectedStringArrayGetSetTestClass
		{
			private protected string[] s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedStringArrayGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedStringArrayGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class InternalStringArrayGetTestClass
		{
			internal string[] s { get; }
		}

		[Test]
		public void IsImmutable_Type_InternalStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalStringArrayGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_InternalStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalStringArrayGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class InternalStringArrayGetSetTestClass
		{
			internal string[] s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_InternalStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalStringArrayGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_InternalStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalStringArrayGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PublicStringArrayGetTestClass
		{
			public string[] s { get; }
		}

		[Test]
		public void IsImmutable_Type_PublicStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringArrayGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringArrayGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringArrayGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PublicStringArrayGetSetTestClass
		{
			public string[] s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PublicStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringArrayGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringArrayGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringArrayGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
	}
}
