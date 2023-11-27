/*
 * C# Program to Swap two Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SwapTwoNumbers
{

    class Program
    {
        /* the 'out' keyword is used when you want a method to return more than one value.
        In the context of the 'double.TryParse' method, the 'out' keyword allows the method
        to return both a boolean indicating whether the parsing was successful and
        the parsed double value. */

        static void Main(string[] args)
        {
            double num1, num2, temp;

            Console.Write("Enter the First Number: ");
            if (double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Enter the Second Number: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    // Swap numbers
                    temp = num1;
                    num1 = num2;
                    num2 = temp;

                    Console.WriteLine("\nAfter Swapping:");
                    Console.WriteLine("First Number: " + num1);
                    Console.WriteLine("Second Number: " + num2);
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }

            Console.Read();
        }
    }

}