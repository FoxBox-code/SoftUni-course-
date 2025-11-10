using System;

namespace _05._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int TVseriesWebying = int.Parse(Console.ReadLine());
            bool Bridge = false;

            for (int i = 1; i <= TVseriesWebying; i++) 
                {
                string SeriesName = Console.ReadLine();
                double priceForSeries  = double.Parse(Console.ReadLine());
                switch (SeriesName) 
                    {
                    case "Thrones": priceForSeries = priceForSeries-(priceForSeries * 0.5); break;
                    case "Lucifer": priceForSeries = priceForSeries - (priceForSeries *  0.4); break;
                    case "Protector": priceForSeries = priceForSeries - (priceForSeries *  0.3);break;
                    case "TotalDrama": priceForSeries = priceForSeries - (priceForSeries * 0.2); break;
                    case "Area": priceForSeries = priceForSeries - (priceForSeries * 0.1);break;
                        default: priceForSeries = priceForSeries; break;


                }
                budget -= priceForSeries;
                


            }
            if (budget < 0) {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
                Bridge = true;
                

            }
            else {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
        }
    }
}
