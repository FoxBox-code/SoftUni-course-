using System;

namespace This_is_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paintbucket = 21.50;
            double wallpaperroll = 5.20;

            double numbuckets = double.Parse(Console.ReadLine());
            double numrows = double.Parse(Console.ReadLine());
            double pricegloves = double.Parse(Console.ReadLine());
            double pricechetka = double.Parse(Console.ReadLine());


            double forpaint = paintbucket * numbuckets;
            double forrows = wallpaperroll * numrows;
            double glovesneeded = (numrows * 0.35);
            glovesneeded = Math.Ceiling(glovesneeded);

            double neededchetki = (numbuckets * 0.48);
             
            neededchetki = Math.Floor(neededchetki);

            double forgloves = glovesneeded * pricegloves;
            double forchetki = pricechetka * neededchetki;
            glovesneeded = 7;
            double totalsum = forpaint + forrows + forgloves + forchetki;
            double delivery = totalsum / 15;


            Console.WriteLine($"This delivery will cost {delivery:f2} lv.");


        }
    }
}
