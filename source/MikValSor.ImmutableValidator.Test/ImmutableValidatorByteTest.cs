using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorByteTest
    {
        [Test]
        public void IsImmutable_byte_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            byte target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_object_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (byte)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_Type_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(byte);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void EnsureImmutable_object_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (byte)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Test]
        public void EnsureImmutable_byte_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            byte target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Test]
        public void EnsureImmutable_Type_byte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(byte);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
