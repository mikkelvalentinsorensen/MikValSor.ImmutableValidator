using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorUlongTest
    {
        [Fact]
        public void IsImmutable_ulong_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            ulong target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (ulong)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ulong);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (ulong)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_ulong_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            ulong target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_ulong()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ulong);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
