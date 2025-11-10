using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());                                               //85  75  47  17
            double height = double.Parse(Console.ReadLine());                                                   //105  77  89  18.5

            double procent = double.Parse(Console.ReadLine());
            
            double volume = side * width * height;
            double volumeinL = volume / 1000;
            double spacetaken = procent / 100;
            double litersneeded = volumeinL * (1 - spacetaken);
            Console.WriteLine(litersneeded);
        }
    }
}
