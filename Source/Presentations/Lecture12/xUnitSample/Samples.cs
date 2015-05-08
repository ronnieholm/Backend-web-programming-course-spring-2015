// Install NuGet packages
//   - xunit
//   - xunit.runner.visualstudio

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitSample
{
    public class Samples
    {
        [Fact]
        public void ShowAssertionsPassing()
        {
            Assert.Equal(5, 5);
        }

        [Fact]
        public void ShowAssertionFailing()
        {
            //Assert.Equal(3, 42);
            //Assert.False(true);
        }

        [Theory, 
        InlineData(1, 2, 3),
        InlineData(21, 31, 52),
        InlineData(0, 0, 0)]
        public void Addition(int op1, int op2, int sum)
        {
            Assert.Equal(sum, op1 + op2);
        }
    }
}
