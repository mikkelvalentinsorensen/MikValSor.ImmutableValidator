using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorInheritanceTest
    {
        private abstract class AbstractTestClass
        {
        }

        [Test]
        public void IsImmutable_Type_AbstractTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(AbstractTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsFalse(actual);
        }

        private class DecendingMutableTestClass : AbstractTestClass
        {
            private string s;
        }

        [Test]
        public void IsImmutable_object_DecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new DecendingMutableTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsFalse(actual);
        }


        [Test]
        public void IsImmutable_Type_DecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(DecendingMutableTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsFalse(actual);
        }

        private sealed class SealingDecendingMutableTestClass : DecendingMutableTestClass
        {
        }

        [Test]
        public void IsImmutable_object_SealingDecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new SealingDecendingMutableTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void IsImmutable_Type_SealingDecendingMutableTestClass()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(SealingDecendingMutableTestClass);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsFalse(actual);
        }

    }
}
