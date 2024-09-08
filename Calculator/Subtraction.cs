using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Subtraction
    {
        public void Subtract(int[] subtractInputs)
        {
            int result = subtractInputs[0];
            for (int i = 1; i < subtractInputs.Length; i++)
            {
                result -= subtractInputs[i];
            }
            Console.WriteLine("The result of the subtraction is: " + result);
        }
    }
}
