using System;

namespace _05._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorname = Console.ReadLine();
            double startingpoints = double.Parse(Console.ReadLine());
            int numOfJurys = int.Parse(Console.ReadLine());
            double Totalpoints = 0;

            for (int i = 1; i <= numOfJurys; i++) {
                string nameOfJury = Console.ReadLine();
                double verdict = double.Parse(Console.ReadLine());
                Totalpoints = nameOfJury.Length * verdict / 2;

                startingpoints += Totalpoints;
                if (startingpoints > 1250.50) {
                    Console.WriteLine($"Congratulations, {actorname} got a nominee for leading role with {startingpoints:f1}!");
                    return;
                }


            }
            
            
                double neededpoints = 1250.5 - startingpoints;
                Console.WriteLine($"Sorry, {actorname} you need {neededpoints:f1} more!");
            
        }
    }
}
