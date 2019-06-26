using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorShortTest
    {
        [Fact]
        public void IsImmutable_short_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            short target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (short)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(short);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (short)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_short_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            short target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_short()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(short);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
