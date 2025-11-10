using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moviebudget = int.Parse(Console.ReadLine());
            string destinatnion = Console.ReadLine();
            string season = Console.ReadLine();
            int  numdays = int.Parse(Console.ReadLine());

            double price = 0;
            double totalprice = 0;

            switch (season) 
                {
                case "Winter":
                    switch (destinatnion) 
                        {
                        case "Dubai": price = 45000; break;
                        case "Sofia": price = 17000; break;
                        case "London": price = 24000; break;


                    }
                    break;
                case "Summer":
                    switch (destinatnion)
                        {
                        case "Dubai": price = 40000; break;
                        case "Sofia": price = 12500; break;
                        case "London": price= 20250; break;
                    }
                    break;


            }
             totalprice = numdays * price;
            if (destinatnion == "Dubai" && season == "Winter") 
                {
                totalprice = totalprice - (totalprice * 0.30);
                

            }
            else if (destinatnion == "Dubai" && season == "Summer") 
                {
                totalprice = totalprice - (totalprice * 0.30);
            }
            else if (destinatnion == "London" && season == "Winter")
                {
                totalprice = totalprice;
            }
            else if (destinatnion == "London" && season == "Summer") 
                {
                totalprice = totalprice;
            }
            else if (destinatnion == "Sofia" && season == "Winter")
                {
                totalprice = totalprice + (totalprice * 0.25);
            }
            else if (destinatnion == "Sofia" && season == "Summer") 
                {
                totalprice = totalprice + (totalprice * 0.25);
            }
            if (totalprice > moviebudget) 
                {
                totalprice = totalprice - moviebudget;
                Console.WriteLine($"The director needs {totalprice:F2} leva more!");
            }
            else if (totalprice < moviebudget) {
                totalprice = moviebudget - totalprice;
                Console.WriteLine($"The budget for the movie is enough! We have {totalprice:F2} leva left!");
            }

        }
    }
}
