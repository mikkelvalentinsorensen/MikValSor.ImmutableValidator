using Xunit;
using System.Collections.ObjectModel;

namespace MikValSor.Immutable.Test
{
    public class ImmutableValidatorReadOnlyCollectionTest
    {
        [Fact]
        public void ImmutableValidator_ReadOnlyCollection_NotUsableAssumption()
        {
            //Arrange
            var source = new char[] { 'A' };
            var readonlyCollection = new ReadOnlyCollection<char>(source);

            //Act
            source[0] = 'B';

            //Assert
            Assert.NotEqual('A', readonlyCollection[0]);
        }
        [Fact]
        public void ImmutableValidator_ReadOnlyCollection_UsableIfClonedAssumption()
        {
            //Arrange
            var source = new char[] { 'A' };
            var readonlyCollection = new ReadOnlyCollection<char>((char[])source.Clone());

            //Act
            source[0] = 'B';

            //Assert
            Assert.Equal('A', readonlyCollection[0]);
        }
    }
}
