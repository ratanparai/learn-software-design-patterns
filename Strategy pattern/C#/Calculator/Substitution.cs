using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Substitution : ICalculate
    {
        public int Calculate(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
}
