using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MultiplicationTable
    {
        double result;
        public void multiplicationTable()
        {
            double firstInput;
            double limit;
            double count = 1;

            Console.WriteLine("Enter the number to have multiplication table:");
            while (!double.TryParse(Console.ReadLine(), out firstInput))
            {
                Console.WriteLine("Enter the valid number:");
            }
            Console.WriteLine("Enter the last limit of the multiplication table:");
            while (!double.TryParse(Console.ReadLine(), out limit))
            {
                Console.WriteLine("Enter the valid number:");

            }
            Console.WriteLine("The multiplilcation table of " + firstInput);
            for (double i = 1; i <= limit; i++)
            {
                result = firstInput * count;
                Console.WriteLine(firstInput + " * " + count + " = " + result);
                count++;
            }
        }
    }
}
