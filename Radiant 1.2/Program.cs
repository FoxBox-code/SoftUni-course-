using System;

namespace Radiant_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiant = double.Parse(Console.ReadLine());
            double degree;
            degree = radiant * 180 / Math.PI;
            Console.WriteLine(degree);
        }
    }
}
