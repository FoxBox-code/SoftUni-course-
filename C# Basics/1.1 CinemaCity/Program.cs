using System;

namespace _1._1_CinemaCity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeprojection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double premierprise = 12.00;
            double standartprise = 7.50;
            double discountprise = 5.00;
            double seats = 0;
            double profit;

            if (typeprojection == "Premiere") 
                {
                seats = rows * columns;
                profit = seats * premierprise;
                Console.WriteLine($"{profit:F2}l");

                





            }
            else if (typeprojection == "Normal") 
                {
                seats = rows * columns;
                profit = seats * premierprise;
                Console.WriteLine($"{profit:F2}leva");
            }
            else if (typeprojection == "Discount") 
                {
                seats = rows * columns;
                profit = seats * premierprise;
                Console.WriteLine($"{profit:F2}leva");
            }
        }
    }
}
