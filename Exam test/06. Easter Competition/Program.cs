using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numcackes = int.Parse(Console.ReadLine());
            int highestpoints = int.MinValue;
            string ChefName;
            string leader = null;

            for (int i = 1; i <= numcackes; i++) 
                {
                 ChefName = Console.ReadLine();
                int points = 0;
                string command = Console.ReadLine();
                while (command != "Stop") 
                    {
                    int givenpoints = int.Parse(command);
                    points = givenpoints + points;
                    command = Console.ReadLine();

                }
                Console.WriteLine($"{ChefName} has {points} points.");
                if (points > highestpoints) 
                    {
                    highestpoints = points;
                     leader = ChefName;
                    Console.WriteLine($"{leader} is the new number 1!");
                }

            }
            Console.WriteLine($"{leader} won competition with {highestpoints} points!");

        }
    }
}
