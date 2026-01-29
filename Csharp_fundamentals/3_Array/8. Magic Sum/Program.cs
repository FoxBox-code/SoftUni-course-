using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynumb = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberToEqual = int.Parse(Console.ReadLine());

            for (int i = 0; i < arraynumb.Length-1; i++)
            {
                for (int j = 1+i; j < arraynumb.Length ; j++)
                {
                    int sum = arraynumb[i] + arraynumb[j];

                    if (sum == numberToEqual)
                    {
                        Console.WriteLine($"{arraynumb[i]} {arraynumb[j]}");

                    }
                }
            }
        }
    }
}
