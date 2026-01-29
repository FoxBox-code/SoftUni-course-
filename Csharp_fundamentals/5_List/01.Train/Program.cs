using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> filledWagons = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string commad;

            while ((commad = Console.ReadLine()) != "end")
            {
                string[] order = commad.Split();
                string instruction = order[0];

                if (instruction == "Add")
                {
                    int value = int.Parse(order[1]);
                    filledWagons.Add(value);
                }
                else
                {
                    int value = int.Parse(order[0]);
                    for (int i = 0; i < filledWagons.Count; i++)
                    {
                        int sum = 0;
                        sum = filledWagons[i] + value;
                        if (sum <= maxCapacity)
                        {
                            filledWagons[i] = sum;
                            break;
                        }
                        

                    }

                }

                
            }
            Console.WriteLine(String.Join(" ", filledWagons));
        }
    }
}
