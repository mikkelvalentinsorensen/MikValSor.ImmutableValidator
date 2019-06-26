using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorObjectTest
    {
        [Fact]
        public void IsImmutable_object_object()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new object();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_object()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(object);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
    }
}
