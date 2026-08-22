using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorApp
{
    /// <summary>
    /// Holds the core calculator logic, kept separate from Program.cs
    /// so it is easy to unit test and easy to extend during practice.
    /// </summary>
    public class Calculator
    {
        // this is the addition i have done for this calculator
        public double Add(double a, double b)
        {
            return a + b;

        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }


        // This is the code.
        public double Multiply(double a, double b)
        {
           return a* b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
                return 0;
            }

            double result = 0;
           return a / b;
        }

        public double add2(double a, double b)
        {
            return a + b;
        }

        // Practice idea: add more operations here, e.g. Power, SquareRoot,
        // Modulus, Percentage — then commit each one as a separate git commit
        // so you have real history to practice rebase/merge on.
    }
}
