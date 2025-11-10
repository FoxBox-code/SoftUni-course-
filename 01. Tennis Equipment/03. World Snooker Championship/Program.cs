using System;

namespace _03._World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string tiket = Console.ReadLine();
            int numtikets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double price = 0;
            bool picture = true;
            if (photo == 'N') {
                picture = false;
            }

            if (stage == "Quarter final") {
                switch (tiket) {
                    case "Standard": price = 55.50; break;
                    case "Premium": price = 105.20; break;
                    case "VIP": price = 118.90; break;

                }
            }
            else if (stage == "Semi final") {
                switch (tiket) {
                    case "Standard": price = 75.88; break;
                    case "Premium": price = 125.22; break;
                    case "VIP": price = 300.40; break;

                }
            }
            else if (stage == "Final") {
                switch (tiket) {
                    case "Standard": price = 110.10; break;
                    case "Premium": price = 160.66; break;
                    case "VIP": price = 160.66; break;

                }
            }
            double Totalprice = numtikets * price;
            double compare = 0;
            if (Totalprice > 4000) {
                compare = Totalprice;
            }
            if (Totalprice > 4000) {
                Totalprice = Totalprice - (Totalprice * 0.25);
                picture = false;
            }
            else if (Totalprice > 2500) {
                Totalprice = Totalprice - (Totalprice * 0.10);
            }
            if (picture) {

                if ((compare < 4000)) {
                    Totalprice = Totalprice + (numtikets * 40);
                }
                

            }
            Console.WriteLine($"{Totalprice:f2}");


        }
    }
}























