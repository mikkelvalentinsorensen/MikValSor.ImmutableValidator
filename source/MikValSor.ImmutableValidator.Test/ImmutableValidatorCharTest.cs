﻿using Xunit;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorCharTest
    {
        [Fact]
        public void IsImmutable_char_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            char target = '0';

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_object_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = '0';

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsImmutable_Type_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(char);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void EnsureImmutable_object_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = '0';

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Fact]
        public void EnsureImmutable_char_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            char target = '0';

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Fact]
        public void EnsureImmutable_Type_char()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(char);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
