using NUnit.Framework;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorValuesTypeTest
	{
		[Test]
		public void IsImmutable_object_bool()
		{
			//Arrange
			var validator = new ImmutableValidator();
			bool target = true;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_bool()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(bool);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_byte()
		{
			//Arrange
			var validator = new ImmutableValidator();
			byte target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_byte()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(byte);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_char()
		{
			//Arrange
			var validator = new ImmutableValidator();
			char target = '0';

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_char()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(char);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			decimal target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_decimal()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(decimal);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_double()
		{
			//Arrange
			var validator = new ImmutableValidator();
			double target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_double()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(double);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		private enum TestEnum { Test }

		[Test]
		public void IsImmutable_object_enum()
		{
			//Arrange
			var validator = new ImmutableValidator();
			TestEnum target = TestEnum.Test;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_enum()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(TestEnum);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_float()
		{
			//Arrange
			var validator = new ImmutableValidator();
			float target = 0;

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
		public void IsImmutable_object_int()
		{
			//Arrange
			var validator = new ImmutableValidator();
			int target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_int()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(int);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			long target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_long()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(long);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_sbyte()
		{
			//Arrange
			var validator = new ImmutableValidator();
			sbyte target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_sbyte()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(sbyte);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			short target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_short()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(short);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			uint target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_uint()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(uint);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ulong()
		{
			//Arrange
			var validator = new ImmutableValidator();
			ulong target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_ulong()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ulong);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ushort()
		{
			//Arrange
			var validator = new ImmutableValidator();
			ushort target = 0;

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}
		[Test]
		public void IsImmutable_Type_ushort()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(ushort);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

	}
}
