using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogfoodKG = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double foodGrams = dogfoodKG * 1000;
            double totalfoodeaten = 0;



            while (command != "Adopted") 
                {
                double foodeaten = double.Parse(command);
                 
                totalfoodeaten = foodeaten + totalfoodeaten;

                
                command = Console.ReadLine();

            }
            if (foodGrams < totalfoodeaten) 
                {

                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodGrams-totalfoodeaten)} grams more.");
                return;
            }

            Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(foodGrams - totalfoodeaten)} grams.");
        }
    }
}
