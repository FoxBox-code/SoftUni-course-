using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersnumb = int.Parse(Console.ReadLine());
            
            decimal totalprice = 0;
            decimal perorderprice = 0;


            for (int i = 1; i <= ordersnumb; i++)
            {
                decimal pricepercapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capcount = int.Parse(Console.ReadLine());

                perorderprice = (days * capcount) * pricepercapsule;
                Console.WriteLine($"The price for the coffee is: ${perorderprice:f2}");
                totalprice +=perorderprice;



            }
            Console.WriteLine($"Total: ${totalprice:f2}");
        }
    }
}
