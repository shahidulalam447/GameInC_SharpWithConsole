
//Perform all Basic Arithmetic Operations

using System;

namespace PerformAllArithmeticOperations
{
    class Program
    {
        static void Main()
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the C# Console Calculator!");

            // Variable to store the user's choice
            char operation;

            do
            {
                // Display the menu
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                // Get user input for the operation
                Console.Write("Enter the number of your choice for an action: ");
                operation = Console.ReadKey().KeyChar;

                // Check the user's choice and perform the corresponding operation
                switch (operation)
                {
                    case '1':
                        PerformAddition();
                        break;
                    case '2':
                        PerformSubtraction();
                        break;
                    case '3':
                        PerformMultiplication();
                        break;
                    case '4':
                        PerformDivision();
                        break;
                    case '5':
                        Console.WriteLine("\nExiting the calculator. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a valid option.");
                        break;
                }

            } while (operation != '5'); // Continue the loop until the user chooses to exit
        }

        // Function to perform addition
        static void PerformAddition()
        {
            Console.Write("\nEnter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");
        }

        // Function to perform subtraction
        static void PerformSubtraction()
        {
            Console.Write("\nEnter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
        }

        // Function to perform multiplication
        static void PerformMultiplication()
        {
            Console.Write("\nEnter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
        }

        // Function to perform division
        static void PerformDivision()
        {
            Console.Write("\nEnter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                double result = dividend / divisor;
                Console.WriteLine($"Result: {dividend} / {divisor} = {result}");
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }
    }

}
