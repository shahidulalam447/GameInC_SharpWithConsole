
//Check the Entered Number is a Perfect Number or Not
/*
 In this program, if the user inputs an even number (perfect number), 
the sum and prime numbers are compared by their numbers. 
Some even number examples of this type are:

If user input 6 then 1 + 2 + 3 = 6, and 6 is an even number.
If user input 28 then 1 + 2 + 4 + 7 + 14 = 28, and 28 is an even number.
 */


using System;

namespace CheckEnteredNumber_isPerfectOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;

            // Input Validation
            do
            {
                Console.Write("Enter a positive number: ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("\nEntered number is a perfect number");
            }
            else
            {
                Console.WriteLine("\nEntered number is not a perfect number");
            }

            Console.ReadLine(); // Wait for user input
        }
    }
}
