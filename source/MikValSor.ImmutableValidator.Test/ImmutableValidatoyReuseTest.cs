using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatoyReuseTest
    {
        private sealed class WrapTestObject
        {
            public readonly object Value;
            public WrapTestObject(object value)
            {
                Value = value;
            }
        }

        [Fact]
        public void TestObject1()
        {
            //Arrange
            var validator = new ImmutableValidator();
            var object1 = new WrapTestObject(new object());

            //Act
            var result1 = validator.IsImmutable(object1);

            //Assert
            Assert.True(result1);
        }

        [Fact]
        public void TestObject2()
        {
            //Arrange
            var validator = new ImmutableValidator();
            var object2 = new WrapTestObject(new object[1] { 1 });

            //Act
            var result2 = validator.IsImmutable(object2);

            //Assert
            Assert.False(result2);
        }

        [Fact]
        public void TestObject1and2()
        {
            //Arrange
            var validator = new ImmutableValidator();
            var object1 = new WrapTestObject(new object());
            var object2 = new WrapTestObject(new object[1] { 1 });

            //Act
            var result1 = validator.IsImmutable(object1);
            var result2 = validator.IsImmutable(object2);

            //Assert
            Assert.True(result1);
            Assert.False(result2);
        }
    }
}
