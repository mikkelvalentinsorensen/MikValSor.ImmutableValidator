using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorDoubleTest
    {
        [Fact]
        public void IsImmutable_double_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            double target = 0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (double)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(double);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (double)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_double_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            double target = 0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_double()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(double);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
