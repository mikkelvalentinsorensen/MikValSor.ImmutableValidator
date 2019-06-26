using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorEnumTest
    {
        private enum MyEnum
        {
            A,
            B
        }

        [Fact]
        public void IsImmutable_object_MyEnum()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = MyEnum.A;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Enum_MyEnum()
        {
            //Arrange
            var validator = new ImmutableValidator();
            MyEnum target = MyEnum.A;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_MyEnum()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(MyEnum);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_MyEnumArray()
        {
            //Arrange
            var validator = new ImmutableValidator();
            MyEnum[] target = new[] { MyEnum.A, MyEnum.B };

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_Type_MyEnumArray()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(MyEnum[]);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
    }
}
