using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// Strategy Interface that will be implemented by all of the calculator
    /// classes
    /// </summary>
    public interface ICalculate
    {
        /// <summary>
        /// Perform the calculation. Every class that implement this interface
        /// will use this method to inplement their own algothm of calculation.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns></returns>
        int Calculate(int numberOne, int numberTwo);
    }
}
