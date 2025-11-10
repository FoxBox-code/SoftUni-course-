using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numlocations = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numlocations; i++) {

                double expectedgold = double.Parse(Console.ReadLine());
                int numdaysinlocation = int.Parse(Console.ReadLine());
                double totalgold = 0;

                for (int d =1; d <= numdaysinlocation; d++) 
                    {
                    int goldgained = int.Parse(Console.ReadLine());

                    totalgold += goldgained;
                }
                double avrageday = totalgold / numdaysinlocation;
                if (avrageday >= expectedgold) 
                    {
                    Console.WriteLine($"Good job! Average gold per day: {avrageday:f2}.");
                }
                else {
                    expectedgold = expectedgold - avrageday;
                    Console.WriteLine($"You need {expectedgold:f2} gold.");
                }
            }
        }
    }
}
