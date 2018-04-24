using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorClassFieldsTest
	{
		private sealed class PrivateStringGetTestClass
		{
			private string s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class PrivateStringGetSetTestClass
		{
			private string s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateStringGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateStringGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class ProtectedStringGetTestClass
		{
			protected string s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateStringTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedStringGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedStringGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class ProtectedStringGetSetTestClass
		{
			protected string s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_ProtectedStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ProtectedStringGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ProtectedStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new ProtectedStringGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class PrivateProtectedStringGetTestClass
		{
			private protected string s { get; }
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedStringGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedStringGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class PrivateProtectedStringGetSetTestClass
		{
			private protected string s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PrivateProtectedStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PrivateProtectedStringGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PrivateProtectedStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PrivateProtectedStringGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
		private sealed class InternalStringGetTestClass
		{
			internal string s { get; }
		}

		[Test]
		public void IsImmutable_Type_InternalStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalStringGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_InternalStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalStringGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class InternalStringGetSetTestClass
		{
			internal string s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_InternalStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(InternalStringGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_InternalStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new InternalStringGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		private sealed class PublicStringGetTestClass
		{
			public string s { get; }
		}

		[Test]
		public void IsImmutable_Type_PublicStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringGetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringGetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringGetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private sealed class PublicStringGetSetTestClass
		{
			public string s { get; set; }
		}

		[Test]
		public void IsImmutable_Type_PublicStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(PublicStringGetSetTestClass);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_PublicStringGetSetTestClass()
		{
			//Arrange
			var validator = new ImmutableValidator();
			object target = new PublicStringGetSetTestClass();

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
	}
}
