using System;

namespace Odd_Or_Even_1._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
        //}
    }
}
