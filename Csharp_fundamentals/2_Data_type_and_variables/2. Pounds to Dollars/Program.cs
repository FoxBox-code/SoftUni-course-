using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishpound = decimal.Parse(Console.ReadLine());

            decimal dollars = britishpound * 1.31m;
            Console.WriteLine($"{dollars:f3}");


        }
    }
}
