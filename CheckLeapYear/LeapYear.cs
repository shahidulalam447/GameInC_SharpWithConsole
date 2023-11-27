
//Check the Entered Year is a Leap Year or Not

using System;

namespace CheckLeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            LeapYear obj = new LeapYear();
            obj.ReadData();
            obj.CheckLeapYear();
        }

        private int year;
        public void ReadData()
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Enter the Year in Four Digits: ");

                if (int.TryParse(Console.ReadLine(), out int inputYear))
                {
                    if (inputYear > 0 && inputYear.ToString().Length == 4)
                    {
                        year = inputYear;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid four-digit positive year.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        public void CheckLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }

            Console.ReadLine();
        }
    }
}
