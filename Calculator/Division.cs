using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Division
    {
        double result;
        public void Divide(int[] divideInputs)
        {
            if (divideInputs.Length < 2 || divideInputs[1] == 0)
            {
                Console.WriteLine("Cannot divide. Please provide at least two numbers and ensure the divisor is not zero.");
                return;
            }

            double result = (double)divideInputs[0];
            for (int i = 1; i < divideInputs.Length; i++)
            {
                if (divideInputs[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Skipping division by zero.");
                    continue;
                }
                result /= divideInputs[i];
            }
            Console.WriteLine("The result of the division is: " + result);
        }
    }
}
