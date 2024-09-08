using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Multiplication
    {
        public void Multiply(int[] multiplyInputs)
        {
            int result = 1;
            foreach (int num in multiplyInputs)
            {
                result *= num;
            }
            Console.WriteLine("The multiplication is: " + result);
        }
    }
}
