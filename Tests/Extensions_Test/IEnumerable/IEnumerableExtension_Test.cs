using Extensions.IEnumerable;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Extensions_Test.IEnumerable
{
    public class IEnumerableExtension_Test
    {
        [Fact]
        public void Randomize_Test()
        {
            try
            {
                //Arrange
                var testList = new List<string> { "First", "Second", "Third", "Forth" };
                //Act
                var result = testList.Randomize();
                //Assert
                result.SequenceEqual(testList).ShouldBeFalse();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
