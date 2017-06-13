using System;

namespace Calculator
{
    public class Addition : ICalculate
    {

        public int Calculate(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
