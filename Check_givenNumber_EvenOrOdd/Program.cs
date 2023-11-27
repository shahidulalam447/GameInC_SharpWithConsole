/*
 * C# Program to Check whether the Entered Number is Even or Odd
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_givenNumber_EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Write("Enter a Number: ");

            if (int.TryParse(Console.ReadLine(), out i))
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Entered Number {0} an Even Number",i);
                }
                else
                {
                    Console.WriteLine("Entered Number {0} an Odd Number",i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }

}