using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();

            double hours = double.Parse(Console.ReadLine());
            double peope = double.Parse(Console.ReadLine());

            string timeofday = Console.ReadLine();

            double totalcost = 0;
            double priceperson = 0;

            switch (mounth) {
                case "march":
                case "april":
                case "may":
                    if (timeofday == "day") {
                        priceperson += 10.50;

                    }
                    else if (timeofday == "night") {
                        priceperson += 8.40;

                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (timeofday == "day") {
                        priceperson += 12.60;

                    }
                    else if (timeofday == "night") {
                        priceperson += 10.20; ;

                    }
                    break;
            }
            if (peope >= 4) {
                priceperson = priceperson - (priceperson * 0.10);


            }
            if (hours >= 5) 
                {
                priceperson = priceperson - (priceperson * 0.50);
            }
            totalcost = priceperson * peope * hours;
            Console.WriteLine($"Price per person for one hour: {priceperson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalcost:f2}");


        }
    }
}
