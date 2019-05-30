using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorBoolTest
    {
        [Test]
        public void IsImmutable_bool_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            bool target = true;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_object_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = true;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_Type_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(bool);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void EnsureImmutable_object_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = true;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Test]
        public void EnsureImmutable_bool_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            bool target = true;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Test]
        public void EnsureImmutable_Type_bool()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(bool);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
