using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorIgnoreAttributeTest
    {
        private sealed class PrivateStringTestClass
        {
            string s;
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class PrivateStringWithAttributeTestClass
        {
            [ImmutableValidatorIgnore]
            string s;
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringWithAttributeTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringWithAttributeTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private abstract class InheritedBaseTestClass
        {
            [ImmutableValidatorIgnore]
            string s;
        }

        private sealed class InheritedTestClass : InheritedBaseTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_InheritedTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InheritedTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }
    }
}
