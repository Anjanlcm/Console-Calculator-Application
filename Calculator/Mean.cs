using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Mean
    {
        public void arithmeticMean(int[] meanInputs)
        {
            if (meanInputs.Length == 0)
            {
                Console.WriteLine("No numbers provided to calculate the average.");
                return;
            }

            double sum = 0;
            foreach (int num in meanInputs)
            {
                sum += num;
            }

            double result = sum / meanInputs.Length;
            Console.WriteLine("The arithmetic mean (average) of the numbers is: " + result);

        }
    }
}
