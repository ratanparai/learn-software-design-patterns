using System;
using Xunit;

namespace Calculator.Tests
{
    class CalculatorTests
    {
        // A test for Calculator addition
        [Fact]
        public void CalculatorAdditionTest()
        {
            // create objects here

            // case 1:  
            int expected = 4;
            int actual = 2+2;
            Assert.Equal(expected, actual);

        }
    }
}
