using System;


namespace DisplayTheATM_Transaction
{
    class Program
    {
        public static void Main()
        {
            int amount = 1000, deposit, withdraw;
            int choice, pin, attempts = 0;

            Console.WriteLine("Enter Your Pin Number: ");
            // Adding error handling for pin input
            if (!int.TryParse(Console.ReadLine(), out pin))
            {
                Console.WriteLine("Invalid PIN. Exiting...");
                return;
            }

            while (attempts < 3)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");

                // Adding error handling for choice input
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        if (!int.TryParse(Console.ReadLine(), out withdraw))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n INSUFFICIENT BALANCE");
                        }
                        else
                        {
                            amount -= withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        if (!int.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        amount += deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU FOR USING ATM");
                        return; // Exit the program
                    default:
                        Console.WriteLine("\n INVALID CHOICE. PLEASE TRY AGAIN.");
                        break;
                }

                attempts++;
            }

            Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
        }
    }

}
