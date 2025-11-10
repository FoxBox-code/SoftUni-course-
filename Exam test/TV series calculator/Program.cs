using System;

namespace TV_series_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TVseries = Console.ReadLine();
            int sesons = int.Parse(Console.ReadLine()); 
            int episodes = int.Parse(Console.ReadLine());
            double eplenght = double.Parse(Console.ReadLine());


            double ads = eplenght * 0.20;
            double epWithAids = ads + eplenght;
            double specialmin = sesons * 10;

            double totalbenchwatch = epWithAids * episodes * sesons + specialmin;

            Console.WriteLine($"Total time needed to watch the {TVseries} series is {totalbenchwatch} minutes.");

        }
    }
}
