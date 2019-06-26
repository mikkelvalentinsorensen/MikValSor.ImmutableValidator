using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorMultiValidateTest
    {
        [Fact]
        public void ImmutableValidator_object_StringAndStringArray()
        {
            var validator = new ImmutableValidator();
            object sArray = new string[0];
            object s = string.Empty;

            //Act
            var s1 = validator.IsImmutable(s);
            var sArray1 = validator.IsImmutable(sArray);
            var s2 = validator.IsImmutable(s);
            var sArray2 = validator.IsImmutable(sArray);

            //Assert
            Assert.True(s1);
            Assert.False(sArray1);
            Assert.True(s2);
            Assert.False(sArray2);
        }
    }
}
