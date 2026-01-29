using System;
using System.Collections.Generic;

namespace _03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] array = command
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = array[0];

                if (array.Length == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    names.Add(name);

                }
                else if (array.Length == 4)
                {
                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                    
                    names.Remove(name);
                }

            }
            PrintList(names);
            
        }




        static void PrintList(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
