using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorInterfaceTest
    {
        private class IDisposableTestClass : System.IDisposable
        {
            public void Dispose()
            {
                throw new System.NotImplementedException();
            }
        }

        [Fact]
        public void IsImmutable_object_IDisposable()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.IDisposable target = new IDisposableTestClass();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_IDisposable()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(System.IDisposable);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
    }
}
