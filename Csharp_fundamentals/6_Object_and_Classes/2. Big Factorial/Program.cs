using System;
using System.Numerics;

namespace _2._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            BigInteger factorialSum = 1;

            for (int i = 1; i <= numb; i++)
            {
                factorialSum = factorialSum * i;
            }
            Console.WriteLine(factorialSum);
        }
    }
}
