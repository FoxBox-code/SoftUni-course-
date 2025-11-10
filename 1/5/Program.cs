using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double fortoys = 0;
            double forswaters = 0;

            int kids = 0;
            int adults = 0;
            string chrismas;
            while ((chrismas = Console.ReadLine()) != "Christmas") 
                {
                double toy = 5.00;
                double sweaters = 15.00;
                double age = double.Parse(chrismas);

                if (age <= 16) 
                    {
                    kids++;
                    fortoys += toy;
                }
                else 
                {
                    adults++;
                    forswaters += sweaters;
                }

            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {fortoys}");
            Console.WriteLine($"Money for sweaters: {forswaters}");
        }
    }
}
