using System;

namespace SupplysForSchool_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bagpens = 5.80;
            double bagmarkers = 7.20;
            double clenearliter = 1.20;

            double numbagpens = double.Parse(Console.ReadLine());
            double nummakrers = double.Parse(Console.ReadLine());
            double literscleaner = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            discount = discount / 100;

            double forpens = bagpens * numbagpens;
            double formarkers = bagmarkers * nummakrers;
            double forliterclenear = clenearliter * literscleaner;
            double Totalprice = forpens + formarkers + forliterclenear;
            double Discountprice = Totalprice - (Totalprice * discount);

            Console.WriteLine(Discountprice );

        }
    }
}
