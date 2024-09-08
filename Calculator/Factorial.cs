using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Factorial
    {
        public void factorial()
        {
            double firstInput;
            double fact = 1;

            Console.WriteLine("Enter the number to factorial:");
            while (!double.TryParse(Console.ReadLine(), out firstInput))
            {
                Console.WriteLine("Enter the valid number:");
            }
            if (firstInput == 0 || firstInput == 1)
            {
                Console.Write("1");
            }
            for (int i = 2; i <= firstInput; i++)
            {
                fact *= i;
            }
            Console.WriteLine("The factorial of " + firstInput + " is " + fact);

        }
    }
}
