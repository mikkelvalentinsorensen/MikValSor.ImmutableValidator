using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorStructTypesTest
    {
        private struct PrivateTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private readonly struct PrivateReadonlyTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateReadonlyTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateReadonlyTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
        private protected struct PrivateProtectedTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private protected readonly struct PrivateProtectedReadonlyTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedReadonlyTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedReadonlyTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        protected struct ProtectedTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_ProtectedTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        protected readonly struct ProtectedReadonlyTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_ProtectedReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedReadonlyTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedReadonlyTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
        internal struct InternalTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_InternalTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        internal readonly struct InternalReadonlyTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_InternalReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalReadonlyTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalReadonlyTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }


        public struct PublicTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PublicTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        public readonly struct PublicReadonlyTestStruct
        {
        }

        [Fact]
        public void IsImmutable_Type_PublicReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicReadonlyTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicReadonlyTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicReadonlyTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
    }
}
