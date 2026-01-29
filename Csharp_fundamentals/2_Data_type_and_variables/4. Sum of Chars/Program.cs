using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCharacters = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 1; i <= numCharacters; i++)
            {
                char input = char.Parse(Console.ReadLine());
                totalSum += input;

            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
