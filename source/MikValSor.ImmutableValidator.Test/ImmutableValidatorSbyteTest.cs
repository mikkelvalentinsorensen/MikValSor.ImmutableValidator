using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorSbyteTest
    {
        [Fact]
        public void IsImmutable_sbyte_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            sbyte target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (sbyte)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(sbyte);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (sbyte)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_sbyte_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            sbyte target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_sbyte()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(sbyte);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
