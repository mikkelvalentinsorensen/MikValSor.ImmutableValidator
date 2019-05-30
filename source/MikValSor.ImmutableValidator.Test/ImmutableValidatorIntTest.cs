using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorIntTest
    {
        [Test]
        public void IsImmutable_int_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            int target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_object_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (int)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_Type_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(int);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void EnsureImmutable_object_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (int)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Test]
        public void EnsureImmutable_int_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            int target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Test]
        public void EnsureImmutable_Type_int()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(int);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}