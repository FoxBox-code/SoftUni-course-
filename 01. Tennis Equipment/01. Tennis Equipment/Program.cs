using System;

namespace _01._Tennis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceracket = double.Parse(Console.ReadLine());
            int tennisrackets = int.Parse(Console.ReadLine());
            int numshoes = int.Parse(Console.ReadLine());

            double TotalforRackets = priceracket * tennisrackets;
            double priceforshoe = priceracket / 6;
            double TotalforShoes = priceforshoe * numshoes;

            double allEqupmentprice = (TotalforRackets + TotalforShoes) * 0.20 + TotalforRackets + TotalforShoes;

            int Tennisplayerfee = (int)allEqupmentprice / 8;
            double moneyPaidBySponsors = Math.Ceiling((allEqupmentprice / 8) * 7);


            Console.WriteLine($"Price to be paid by Djokovic {Tennisplayerfee:f3}");
            Console.WriteLine($"Price to be paid by sponsors {moneyPaidBySponsors}");






        }
    }
}
