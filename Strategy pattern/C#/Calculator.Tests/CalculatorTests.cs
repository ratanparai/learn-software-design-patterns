using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        // A test for Calculator addition
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4,6,10)]
        [InlineData(-5, 4, -1)]
        [InlineData(-2, -7, -9)]
        public void CalculatorAdditionTest(int numberOne, int numberTwo, int expected)
        {
            MyCalculator calculator = new MyCalculator(new Addition());

            int actual = calculator.Calculate(numberOne,numberTwo);
            Assert.Equal(expected, actual);

        }

        // A test for Calculator substitution
        [Theory]
        [InlineData(9, 2, 7)]
        [InlineData(85, 15, 70)]
        [InlineData(-8, 3, -11)]
        [InlineData(8, -1, 9)]
        [InlineData(-5, -3, -2)]
        public void CalculatorSubstitutionTest(int numberOne, int numberTwo, int expected)
        {
            MyCalculator calculator = new MyCalculator(new Substitution());

            int actual = calculator.Calculate(numberOne, numberTwo);
            Assert.Equal(expected, actual);
        }
    }
}
