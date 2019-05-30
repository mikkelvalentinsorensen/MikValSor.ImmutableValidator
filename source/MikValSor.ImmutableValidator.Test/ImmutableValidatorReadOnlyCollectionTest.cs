using NUnit.Framework;
using System.Collections.ObjectModel;

namespace MikValSor.Immutable.Test
{
    [TestFixture]
    public class ImmutableValidatorReadOnlyCollectionTest
    {
        [Test]
        public void ImmutableValidator_ReadOnlyCollection_NotUsableAssumption()
        {
            //Arrange
            var source = new char[] { 'A' };
            var readonlyCollection = new ReadOnlyCollection<char>(source);

            //Act
            source[0] = 'B';

            //Assert
            Assert.AreNotEqual('A', readonlyCollection[0]);
        }
        [Test]
        public void ImmutableValidator_ReadOnlyCollection_UsableIfClonedAssumption()
        {
            //Arrange
            var source = new char[] { 'A' };
            var readonlyCollection = new ReadOnlyCollection<char>((char[])source.Clone());

            //Act
            source[0] = 'B';

            //Assert
            Assert.AreEqual('A', readonlyCollection[0]);
        }
    }
}
