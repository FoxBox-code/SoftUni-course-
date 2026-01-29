using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbKegs = int.Parse(Console.ReadLine());
            double highestPoints = double.MinValue;
            string leader = null; 


            for (int i = 1; i <= numbKegs; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double score = Math.PI * radius + height;
                if (score > highestPoints)
                {
                    highestPoints = score;
                    leader = name;

                }

            }
            Console.WriteLine(leader);
        }
    }
}
