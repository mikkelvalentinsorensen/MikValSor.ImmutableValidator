using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorClassTypesTest
    {
        private sealed class PrivateSealedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateSealedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateSealedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        internal sealed class InternalSealedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_InternalSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalSealedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalSealedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        protected sealed class ProtectedSealedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_ProtectedSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedSealedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedSealedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private protected sealed class PrivateProtectedSealedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedSealedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedSealedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        public sealed class PublicSealedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PublicSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicSealedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicSealedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicSealedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private abstract class PrivateAbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateAbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateAbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        internal abstract class InternalAbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_InternalAbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalAbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        protected abstract class ProtectedAbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_ProtectedAbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedAbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private protected abstract class PrivateProtectedAbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedAbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedAbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        public abstract class PublicAbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PublicAbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicAbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private class PrivateTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
        [Fact]
        public void IsImmutable_object_PrivateTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        internal class InternalTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_InternalTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        protected class ProtectedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_ProtectedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ProtectedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_ProtectedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new ProtectedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private protected class PrivateProtectedTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PrivateProtectedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateProtectedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateProtectedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateProtectedTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        public class PublicTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_PublicTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
    }
}
