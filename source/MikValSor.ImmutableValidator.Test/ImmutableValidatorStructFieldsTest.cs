using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorStructFieldsTest
    {
        private struct PrivateStringGetTestStruct
        {
            private string s { get; }
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringGetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateStringGetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private struct PrivateStringGetSetTestStruct
        {
            private string s { get; set; }
        }

        [Fact]
        public void IsImmutable_Type_PrivateStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PrivateStringGetSetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PrivateStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PrivateStringGetSetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private struct InternalStringGetTestStruct
        {
            internal string s { get; }
        }

        [Fact]
        public void IsImmutable_Type_InternalStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalStringGetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalStringGetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private struct InternalStringGetSetTestStruct
        {
            internal string s { get; set; }
        }

        [Fact]
        public void IsImmutable_Type_InternalStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(InternalStringGetSetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_InternalStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new InternalStringGetSetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        private struct PublicStringGetTestStruct
        {
            public string s { get; }
        }

        [Fact]
        public void IsImmutable_Type_PublicStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicStringGetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicStringGetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicStringGetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        private struct PublicStringGetSetTestStruct
        {
            public string s { get; set; }
        }

        [Fact]
        public void IsImmutable_Type_PublicStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(PublicStringGetSetTestStruct);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void IsImmutable_object_PublicStringGetSetTestStruct()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = new PublicStringGetSetTestStruct();

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.False(actual);
        }
    }
}
