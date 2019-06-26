using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorStructVariabelsTest
    {
        private struct PrivateStringTestStruct
        {
            private string s;
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private struct PrivateReadonlyStringTestStruct
        {
            private readonly string s;
        }

        [Fact]
        public void IsImmutable_Type_PrivateReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateReadonlyStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateReadonlyStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
        private struct PrivateConstStringTestStruct
        {
            private const string s = "";
        }

        [Fact]
        public void IsImmutable_Type_PrivateConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateConstStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateConstStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private struct ProtectedReadonlyStringTestStruct
        {
            private readonly string s;
        }

        [Fact]
        public void IsImmutable_Type_ProtectedReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedReadonlyStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedReadonlyStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
        private struct ProtectedConstStringTestStruct
        {
            private const string s = "";
        }

        [Fact]
        public void IsImmutable_Type_ProtectedConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedConstStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedConstStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private struct PublicStringTestStruct
        {
            public string s;
        }

        [Fact]
        public void IsImmutable_Type_PublicStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private struct PublicReadonlyStringTestStruct
        {
            public readonly string s;
        }

        [Fact]
        public void IsImmutable_Type_PublicReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicReadonlyStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicReadonlyStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicReadonlyStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
        private struct PublicConstStringTestStruct
        {
            public const string s = "";
        }

        [Fact]
        public void IsImmutable_Type_PublicConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicConstStringTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicConstStringTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicConstStringTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
    }
}
