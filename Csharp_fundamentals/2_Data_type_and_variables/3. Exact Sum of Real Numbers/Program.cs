using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numnumbers = int.Parse(Console.ReadLine());
            decimal totalsum = 0;

            for (int i = 1; i <= numnumbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                totalsum += number;

            }
            Console.WriteLine(totalsum);
        }
    }
}
