using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator.Core;

namespace Calculator.Test
{
    public class OperationTests
    {
        ScientificCalculator _calculator;

        public OperationTests()
	    {
            _calculator = new ScientificCalculator();
	    }

        [Fact]
        public void AddIntegers()
        {
            var result = _calculator.Add(10, 32);
            Assert.Equal(42, result);
        }

        [Fact]
        public void ReverseAddIntegers()
        {
            var result = _calculator.Add(32, 10);
            Assert.Equal(42, result);
        }

        [Theory,
        InlineData(10, 32, 42),
        InlineData(32, 10, 42),
        InlineData(0, 0, 0),
        InlineData(0, 42, 42)]
        public void ParameterizedAddition(int op1, int op2, int sum)
        {
            var result = _calculator.Add(op1, op2);
            Assert.Equal(sum, result);
        }
    }
}
