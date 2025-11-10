using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++) 
                {
                for (int m = 1; m <= 10; m++) {
                    int result = n * m;
                    Console.WriteLine($"{n} * {m} = {result}");
                }

            }
        }
    }
}
