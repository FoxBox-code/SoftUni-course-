using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double proccesorneededtobuild = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workingdays = double.Parse(Console.ReadLine());


            double totalhourswokred = workers * workingdays * 8;

            double processor = totalhourswokred / 3;
            processor = Math.Floor(processor);

            double moneymade = 0;


            if (processor >= proccesorneededtobuild) 
                {
                moneymade = processor - proccesorneededtobuild;
                double profit = moneymade * 110.10;
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
            else {
                moneymade = proccesorneededtobuild - processor;
                double profit = moneymade * 110.10;
                Console.WriteLine($"Losses: -> {profit:f2} BGN");
            }

        }
    }
}
