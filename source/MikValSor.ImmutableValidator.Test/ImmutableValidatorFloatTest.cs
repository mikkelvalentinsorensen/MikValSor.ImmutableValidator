﻿using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorFloatTest
    {
        [Test]
        public void IsImmutable_float_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            float target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            var actual = validator.IsImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_object_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (float)0;

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsImmutable_Type_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(float);

            //Act
            var actual = validator.IsImmutable(target);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void EnsureImmutable_object_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            object target = (float)0;

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }

        [Test]
        public void EnsureImmutable_float_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            float target = 0;

            //Act
#pragma warning disable CS0618 // Type or member is obsolete
            validator.EnsureImmutable(target);
#pragma warning restore CS0618 // Type or member is obsolete

            //Assert
        }

        [Test]
        public void EnsureImmutable_Type_float()
        {
            //Arrange
            var validator = new ImmutableValidator();
            System.Type target = typeof(float);

            //Act
            validator.EnsureImmutable(target);

            //Assert
        }
    }
}
