using System;

namespace _3.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbpeople = int.Parse(Console.ReadLine());
            string typeofpeople = Console.ReadLine();
            string dayofvacation = Console.ReadLine();
            decimal price = 0m;
            decimal totalprice = 0m;

            if (typeofpeople == "Students")
            {
                switch (dayofvacation)
                {
                    case "Friday": price = 8.45m;
                        break;
                    case "Saturday": price = 9.80m;
                        break ;
                    case "Sunday": price = 10.46m;
                        break;
                }
                totalprice = price * numbpeople;
                if (numbpeople >= 30)
                {
                    totalprice = totalprice - (totalprice * 0.15m);
                }
            }
            else if (typeofpeople == "Business")
            {
                switch (dayofvacation)
                {
                    case "Friday":
                        price = 10.90m;
                        break;
                    case "Saturday":
                        price = 15.60m;
                        break;
                    case "Sunday":
                        price = 16m;
                        break;
                }
                totalprice = price * numbpeople;
                if (numbpeople >= 100)
                {
                    totalprice = totalprice - (price*10);

                }
            }
            else if (typeofpeople == "Regular")
            {
                switch (dayofvacation)
                {
                    case "Friday":
                        price = 15m;
                        break;
                    case "Saturday":
                        price = 20m;
                        break;
                    case "Sunday":
                        price = 22.50m;
                        break;
                }
                totalprice = price *numbpeople;
                if (numbpeople >= 10 && numbpeople <= 20)
                {
                    totalprice = totalprice - (totalprice * 0.05m);
                }
            }
            Console.WriteLine($"Total price: {totalprice:f2}");



        }
    }
}
