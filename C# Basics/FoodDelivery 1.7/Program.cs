using System;

namespace FoodDelivery_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chikenmenu = 10.35;
            double fishmenu = 12.40;                                                                                 //2  4  3
            double vegetarionmenu = 8.15;
            double delivery = 2.50;

            double numchikenmenu = double.Parse(Console.ReadLine());
            double numfishmenu = double.Parse(Console.ReadLine());
            double numvegetarionmenu = double.Parse(Console.ReadLine());

            double valuechikenmenu = chikenmenu * numchikenmenu;
            double valuefishmenu = fishmenu * numfishmenu;
            double valuevegetarionmenu = vegetarionmenu * numvegetarionmenu;
            double Totalmenuvalue = valuechikenmenu + valuevegetarionmenu + valuefishmenu;
            double addeddesert =  Totalmenuvalue * 0.2 ;
            double WholeOrder = Totalmenuvalue + addeddesert + delivery;
            Console.WriteLine(WholeOrder);
        }
    }
}
