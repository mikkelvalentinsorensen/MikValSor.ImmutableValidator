using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorInheritanceTest
    {
        private abstract class AbstractTestClass
        {
        }

        [Fact]
        public void IsImmutable_Type_AbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(AbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private class DecendingMutableTestClass : AbstractTestClass
        {
            private string s;
        }

        [Fact]
        public void IsImmutable_object_DecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new DecendingMutableTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }


        [Fact]
        public void IsImmutable_Type_DecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(DecendingMutableTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private sealed class SealingDecendingMutableTestClass : DecendingMutableTestClass
        {
        }

        [Fact]
        public void IsImmutable_object_SealingDecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new SealingDecendingMutableTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_Type_SealingDecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(SealingDecendingMutableTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

    }
}
