using System;

namespace Godzilla_vs_Kong_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string faggot = Console.ReadLine();
            double numstatists = double.Parse(faggot);
            double priceforCostume = double.Parse(Console.ReadLine());

            movieBudget = movieBudget - (movieBudget * 0.10);

            double totalforCostume = numstatists * priceforCostume;
            if (numstatists > 150) 
                    {
                totalforCostume = totalforCostume - (totalforCostume * 0.10);

            }
            

            if (movieBudget < totalforCostume) 
                {
                movieBudget = movieBudget - totalforCostume;
                Console.WriteLine($"Not enough money! ");
                Console.WriteLine($"Wingard needs {Math.Abs(movieBudget):f2} leva more.");
            }
            else 
            {
                movieBudget = movieBudget - totalforCostume;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with { movieBudget:F2} leva left.");


            }
            
            


        }
    }
}
