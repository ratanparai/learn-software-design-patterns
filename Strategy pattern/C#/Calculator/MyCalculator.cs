using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MyCalculator
    {
        private ICalculate calc;

        public MyCalculator(ICalculate calculate)
        {
            calc = calculate;
        }

        public int Calculate(int numberOne, int numberTwo)
        {
            return calc.Calculate(numberOne, numberTwo);
        }
    }
}
