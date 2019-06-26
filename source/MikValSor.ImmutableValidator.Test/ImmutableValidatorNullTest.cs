using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorNullTest
    {
        [Fact]
        public void IsImmutable_object_null()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = null;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_null()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = null;

            //Act
            try
            {
                var actual = validator.IsImmutable(target);
            }

            //Assert
            catch (System.ArgumentNullException)
            {
                return;
            }
            Assert.True(false);
        }

    }
}
