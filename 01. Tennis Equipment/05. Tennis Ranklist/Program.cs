using System;

namespace _05._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numtorrnaments = int.Parse(Console.ReadLine());
            int startingpoints = int.Parse(Console.ReadLine());
            double avragepoints = 0;
            double w = 0;
            int pointsgained = 0;
            double winrate = 0;


            for (int i = 1; i <= numtorrnaments; i++) 
                {
                string stage = Console.ReadLine();
                int givenpoints = 0;
                

                switch (stage) 
                    {
                    case "SF": givenpoints = 720; break;
                    case "F": givenpoints = 1200; break;
                    case "W": givenpoints = 2000;w++; break;

                }
                
                pointsgained += givenpoints;
                startingpoints = startingpoints + givenpoints;
                if (i == numtorrnaments) 
                    {
                    avragepoints =pointsgained / numtorrnaments;
                }

            }

            winrate = (w / (double)numtorrnaments);
            winrate = winrate * 100;
            Console.WriteLine($"Final points: {startingpoints}");
            Console.WriteLine($"Average points: {Math.Floor(avragepoints)}");
            Console.WriteLine($"{winrate:f2}%");

        }
    }
}
