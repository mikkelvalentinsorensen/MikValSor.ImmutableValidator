using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorLongTest
    {
        [Fact]
        public void IsImmutable_long_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            long target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (long)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(long);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (long)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_long_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            long target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_long()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(long);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
