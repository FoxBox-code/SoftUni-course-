using System;

namespace Yard_Greening_1._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Garden = double.Parse(Console.ReadLine());
            double km2 = 7.61;
            double discount = 0.18;
            double Jewprice = (Garden * km2  );
            double discountonprice = Garden * km2 * discount;
            double totalprice = Garden * km2 - discountonprice;
            Console.WriteLine(totalprice + " lv.");
            Console.WriteLine(discountonprice + " lv.");
        }
    }
}
