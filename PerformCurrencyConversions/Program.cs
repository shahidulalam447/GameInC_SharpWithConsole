using System;

namespace PerformCurrencyConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your Choice:\n1. Dollar to BDT\n2. Euro to BDT\n3. Malaysian Ringgit to BDT\n4. Quit\n");

            // Adding error handling for choice input
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadLine();
                return;
            }

            switch (choice)
            {
                case 1:
                    double dollar, bdt, val;
                    Console.WriteLine("Enter the Dollar Amount:");

                    // Adding error handling for amount input
                    if (!double.TryParse(Console.ReadLine(), out dollar))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Dollar Amount.");
                        Console.ReadLine();
                        return;
                    }

                    Console.WriteLine("Enter the current BDT Value of 1 Dollar:");

                    // Adding error handling for value input
                    if (!double.TryParse(Console.ReadLine(), out val))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Dollar Value.");
                        Console.ReadLine();
                        return;
                    }

                    bdt = dollar * val;
                    Console.WriteLine("{0} Dollar Equals {1} BDT", dollar, bdt);
                    break;

                case 2:
                    double euro, bdtEuro, valu;
                    Console.WriteLine("Enter the Euro Amount:");

                    // Adding error handling for amount input
                    if (!double.TryParse(Console.ReadLine(), out euro))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Euro Amount.");
                        Console.ReadLine();
                        return;
                    }

                    Console.WriteLine("Enter the current BDT Valueof of Euro:");

                    // Adding error handling for value input
                    if (!double.TryParse(Console.ReadLine(), out valu))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Euro Value.");
                        Console.ReadLine();
                        return;
                    }

                    bdtEuro = euro * valu;
                    Console.WriteLine("{0} Euro Equals {1} BDT", euro, bdtEuro);
                    break;

                case 3:
                    double ringgit, bdtRinggit, value;
                    Console.WriteLine("Enter the Ringgit Amount:");

                    // Adding error handling for amount input
                    if (!double.TryParse(Console.ReadLine(), out ringgit))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Ringgit Amount.");
                        Console.ReadLine();
                        return;
                    }

                    Console.WriteLine("Enter the current BDT Value of 1 Ringgit:");

                    // Adding error handling for value input
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Ringgit Value.");
                        Console.ReadLine();
                        return;
                    }

                    bdtRinggit = ringgit * value;
                    Console.WriteLine("{0} Malaysian Ringgit Equals {1} BDT", ringgit, bdtRinggit);
                    break;
                case 4:
                    Console.WriteLine("\n THANK YOU FOR USING This App");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
