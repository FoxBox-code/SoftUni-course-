using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> collection = new Stack<int>();




            for (int i = 0; i < n; i++)
            {
                int[] order = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int function = order[0];

                if (function == 1)
                {
                    int pushed = order[1];
                    collection.Push(pushed);
                }
                else if (function == 2)
                {
                    collection.Pop();
                }
                else if (function == 3)
                {
                    if (collection.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(collection.Max());
                    }
                }
                else if (function == 4)
                {
                    if (collection.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(collection.Min());
                    }
                }

            }
            Console.WriteLine(String.Join(", ",collection));
        }
    }
}
