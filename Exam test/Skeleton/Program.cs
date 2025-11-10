using System;

namespace Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double Reducedtime = lenght / 120 * 2.5;
            double TimeByMarin = lenght/100 * speed - Reducedtime;
            double control = sec + min * 60;


            if (TimeByMarin <= control) 
                {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($" His time is {TimeByMarin:f3}.");


            }
            else {
                
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(control - TimeByMarin):f3} second slower.");
            }
        }
    }
}
