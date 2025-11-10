using System;

namespace Toy_Shop_1._4
{
    internal class Program                                                                                               // 40.8  20  25  30  50  10
    {
        static void Main(string[] args)
        {
            
            double puzzle = 2.60;
            double talkingdoll = 3.00;
            double teddybear = 4.10;
            double minion = 8.20;
            double truck = 2.00;

            double torism = double.Parse(Console.ReadLine());
            double numpuzzle = double.Parse(Console.ReadLine());
            double numdolls = double.Parse(Console.ReadLine());
            double numteddybears = double.Parse(Console.ReadLine());
            double numminions = double.Parse(Console.ReadLine());
            double numtrucks = double.Parse(Console.ReadLine());

            double sumtoys = puzzle * numpuzzle + talkingdoll * numdolls + teddybear * numteddybears + minion * numminions + truck * numtrucks;
            double numtoys = numpuzzle + numdolls + numteddybears + numminions + numtrucks;
            
            if (numtoys >50) {
                double discount;
                discount = sumtoys * 0.25;
                sumtoys = sumtoys - discount;


            }
            double rent = 0.10 * sumtoys;
            double profit = sumtoys - rent;

            if (profit > torism) {

                double moneyleft = profit - torism;
                Console.WriteLine($"Yes! {moneyleft:F2} lv left.");
            }
            else {
                double needed = torism - profit;

                Console.WriteLine($"Not enough money! {needed:F2} lv needed.");

            }


        }


    }
}
