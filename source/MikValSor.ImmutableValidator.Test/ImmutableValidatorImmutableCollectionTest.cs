using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MikValSor.Immutable.Test
{
	[TestFixture]
	public class ImmutableValidatorImmutableCollectionTest
	{
		[Test]
		public void ImmutableValidator_ImmutableCollection_Assumption()
		{
			//Arrange
			var source = new char[] { 'A' };
			var readonlyCollection = new MikValSor.Immutable.ImmutableCollection<char>(source);

			//Act
			source[0] = 'B';

			//Assert
			Assert.AreEqual('A', readonlyCollection[0]);
		}

		[Test]
		public void IsImmutable_object_ImmutableCollectionChar()
		{
			//Arrange
			var validator = new ImmutableValidator();
			var source = new char[] { 'A' };
			var target = new MikValSor.Immutable.ImmutableCollection<char>(source);

			//Act
			validator.EnsureImmutable(target);
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_object_ImmutableCollectionObject()
		{
			//Arrange
			var validator = new ImmutableValidator();
			var source = new object[] { new object(), new object() };
			var target = new MikValSor.Immutable.ImmutableCollection<object>(source);

			//Act
			validator.EnsureImmutable(target);
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_ImmutableCollectionChar()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(MikValSor.Immutable.ImmutableCollection<char>);

			//Act
			validator.EnsureImmutable(target);
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_ImmutableCollectionCharArray()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(MikValSor.Immutable.ImmutableCollection<char[]>);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ImmutableCollectionCharList()
		{
			//Arrange
			var validator = new ImmutableValidator();
			var source = new List<char>[] { new List<char>(), new List<char>() };
			var target = new MikValSor.Immutable.ImmutableCollection<List<char>>(source);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}

		[Test]
		public void IsImmutable_object_ImmutableCollectionCharListAsObject()
		{
			//Arrange
			var validator = new ImmutableValidator();
			var source = new List<char>[] { new List<char>(), new List<char>() };
			var target = new MikValSor.Immutable.ImmutableCollection<object>(source);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
	}
}
