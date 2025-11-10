using System;

namespace _05._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numvisitors = int.Parse(Console.ReadLine());

            int back =0;
            int chest =0;
            int legs =0;
            int abs =0;
            int proteinshake = 0;
            int bar =0;
            int workoutdone = 0;
            int products = 0;


            for (int i = 1; i <= numvisitors; i++) 
                {
                string activity = Console.ReadLine();

                switch (activity) 
                    {
                    case "Back":back++;workoutdone++; break;
                    case "Chest": chest++; workoutdone++; break;
                    case "Legs": legs++; workoutdone++; ; break;
                    case "Abs": abs++; workoutdone++;  break;
                    case "Protein shake": proteinshake++;products++; break;
                    case "Protein bar": bar++; products++; break;


                }


            }
            double RateWorkout = ((double)workoutdone / numvisitors) *100;
            double Sold = ((double)products / numvisitors) *100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinshake} - protein shake");
            Console.WriteLine($"{bar} - protein bar");
            Console.WriteLine($"{RateWorkout:f2}% - work out");
            Console.WriteLine($"{Sold:f2}% - protein");
        }
    }
}
