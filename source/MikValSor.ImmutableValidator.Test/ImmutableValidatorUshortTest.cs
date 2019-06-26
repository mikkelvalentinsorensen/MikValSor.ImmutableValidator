using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorUshortTest
    {
        [Fact]
        public void IsImmutable_ushort_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            ushort target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (ushort)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ushort);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (ushort)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_ushort_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            ushort target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_ushort()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(ushort);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
