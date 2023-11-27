
//C# Program to Calculate nPr

using System;

namespace Find_nPr_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, per, fact, fact1;
            Console.WriteLine("Enter the Value of 'n' and 'r' " + "to find the Permutation :");
            n = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            fact = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            int number;
            number = n - r;
            fact1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fact1 = fact1 * i;
            }
            per = fact / fact1;
            Console.WriteLine("Permutation : {0}", per);
            Console.ReadLine();
        }
    }
}