using System;

namespace _04._Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Moviebudget = double .Parse(Console.ReadLine());
            string command = Console.ReadLine();

            bool Bridge = false;
            while (command != "ACTION") 
                {
                string actorname = command;
                double salary = 0;
                if (actorname.Length <= 15) 
                    {
                    salary = double.Parse(Console.ReadLine());

                }
                else {
                    salary = 0.20 * Moviebudget;
                }
                Moviebudget -= salary;
                if (Moviebudget <= 0) 
                    {
                    Console.WriteLine($"We need {Math.Abs(Moviebudget):F2} leva for our actors.");
                    Bridge = true;
                    break;
                }
                command = Console.ReadLine();
            }
            if (!Bridge) 
                {
                Console.WriteLine($"We are left with {Moviebudget:F2} leva.");

            }

        }
    }
}
