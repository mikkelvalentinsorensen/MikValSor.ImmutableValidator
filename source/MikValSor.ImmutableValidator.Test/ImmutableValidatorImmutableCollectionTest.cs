﻿using NUnit.Framework;
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
			var readonlyCollection = new MikValSor.Immutable.ImmutablCollection<char>(source);

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
			var target = new MikValSor.Immutable.ImmutablCollection<char>(source);

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
			System.Type target = typeof(MikValSor.Immutable.ImmutablCollection<char>);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsTrue(actual);
		}

		[Test]
		public void IsImmutable_Type_ImmutableCollectionCharArray()
		{
			//Arrange
			var validator = new ImmutableValidator();
			System.Type target = typeof(MikValSor.Immutable.ImmutablCollection<char[]>);

			//Act
			var actual = validator.IsImmutable(target);

			//Assert
			Assert.IsFalse(actual);
		}
	}
}