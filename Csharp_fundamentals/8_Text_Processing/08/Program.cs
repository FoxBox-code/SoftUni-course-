using System;
using System.ComponentModel;

namespace _08.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;


            foreach (string line in input)
            {
                char firstLetter = line[0];
                char lastLetter = line[^1];

                string numbInString = line.Substring(1, 2);

                double num = double.Parse(numbInString);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfLetter = firstLetter - 64;
                    num /= positionOfLetter;

                }
                else
                {
                    int positionOfLetter = firstLetter - 96;
                    num *= positionOfLetter;

                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfLetter = lastLetter - 64;
                    num -= positionOfLetter;
                }
                else
                {
                    int positionOfLetter = lastLetter - 96;
                    num += positionOfLetter;
                }
                sum += num;






            }
            Console.WriteLine($"{sum:f2}");

        }
    }
}
