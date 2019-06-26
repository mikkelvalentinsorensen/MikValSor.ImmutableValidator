using Xunit;

namespace MikValSor.Immutable.Test
{
    
    public class ImmutableValidatorClassVariabelArraysTest
    {
        private sealed class PrivateStringArrayTestClass
        {
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0044 // Add readonly modifier
            private string[] s;
#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class PrivateReadonlyStringArrayTestClass
        {
#pragma warning disable IDE0051 // Remove unused private members
            private readonly string[] s;
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void IsImmutable_Type_PrivateReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateReadonlyStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateReadonlyStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
        private sealed class PrivateConstStringArrayTestClass
        {
#pragma warning disable IDE0051 // Remove unused private members
            private const string[] s = null;
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void IsImmutable_Type_PrivateConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateConstStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateConstStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private sealed class ProtectedStringArrayTestClass
        {
#pragma warning disable CS0628 // New protected member declared in sealed class
            protected string[] s;
#pragma warning restore CS0628 // New protected member declared in sealed class
        }

        [Fact]
        public void IsImmutable_Type_ProtectedStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class ProtectedReadonlyStringArrayTestClass
        {
#pragma warning disable IDE0051 // Remove unused private members
            private readonly string[] s;
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void IsImmutable_Type_ProtectedReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedReadonlyStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedReadonlyStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
        private sealed class ProtectedConstStringArrayTestClass
        {
#pragma warning disable IDE0051 // Remove unused private members
            private const string[] s = null;
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void IsImmutable_Type_ProtectedConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedConstStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedConstStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private sealed class PrivateProtectedStringArrayTestClass
        {
#pragma warning disable CS0628 // New protected member declared in sealed class
            private protected string[] s;
#pragma warning restore CS0628 // New protected member declared in sealed class
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class PrivateProtectedReadonlyStringArrayTestClass
        {
#pragma warning disable CS0628 // New protected member declared in sealed class
            private protected readonly string[] s;
#pragma warning restore CS0628 // New protected member declared in sealed class
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedReadonlyStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedReadonlyStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
        private sealed class PrivateProtectedConstStringArrayTestClass
        {
#pragma warning disable CS0628 // New protected member declared in sealed class
            private protected const string[] s = null;
#pragma warning restore CS0628 // New protected member declared in sealed class
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedConstStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedConstStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private sealed class PublicStringArrayTestClass
        {
            public string[] s;
        }

        [Fact]
        public void IsImmutable_Type_PublicStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class PublicReadonlyStringArrayTestClass
        {
            public readonly string[] s;
        }

        [Fact]
        public void IsImmutable_Type_PublicReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicReadonlyStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicReadonlyStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicReadonlyStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
        private sealed class PublicConstStringArrayTestClass
        {
            public const string[] s = null;
        }

        [Fact]
        public void IsImmutable_Type_PublicConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicConstStringArrayTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicConstStringArrayTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicConstStringArrayTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
    }
}
