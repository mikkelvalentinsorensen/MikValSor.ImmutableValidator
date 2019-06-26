using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorArrayTest
    {
        [Fact]
        public void IsImmutable_array_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            string[] target = new string[1];

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new string[1]; ;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_Type_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(string[]);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void EnsureImmutable_object_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new string[1]; ;

            //Act
            try
            {
                validator.EnsureImmutable(target);
            }

            //Assert
            catch (NotImmutableException)
            {
                return;
            }
            Assert.True(false);
        }

        [Fact]
        public void EnsureImmutable_array_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            string[] target = new string[1]; ;

            //Act
            try
            {
                validator.EnsureImmutable(target);
            }

            //Assert
            catch (NotImmutableException)
            {
                return;
            }
            Assert.True(false);
        }

        [Fact]
        public void EnsureImmutable_Type_array()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(string[]);

            //Act
            try
            {
                validator.EnsureImmutable(target);
            }

            //Assert
            catch (NotImmutableException)
            {
                return;
            }
            Assert.True(false);
        }
    }
}
