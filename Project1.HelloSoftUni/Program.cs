using System;

namespace Project1.HelloSoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double dogbag = double.Parse(Console.ReadLine());
            double bag1 = dogbag * 2.50;
            double catbag = double.Parse(Console.ReadLine());
            double bag2 = catbag * 4;
            double sum = bag1 + bag2;
            Console.WriteLine($"{ sum } lv.");







        }
    }
}
