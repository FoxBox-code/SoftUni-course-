using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] strings = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string order = strings[0];


                if (order == "Add")
                {
                    int numb = int.Parse(strings[1]);
                    numbers.Add(numb);
                }
                else if (order == "Insert")
                {
                    int numb = int.Parse(strings[1]);


                    int index = int.Parse(strings[2]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numb);
                }

                else if (order == "Remove")
                {
                    int numb = int.Parse(strings[1]);
                    if (numb >= numbers.Count || numb < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(numb);
                }
                else if (strings[1] == "right")
                {
                    int times = int.Parse(strings[2]);

                    for (int i = 1; i <= times; i++)
                    {
                        int lastnumb = numbers[numbers.Count - 1];

                        for (int j = numbers.Count - 1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];

                        }
                        numbers[0] = lastnumb;
                    }

                }
                else if (strings[1] == "left")
                {
                    int times = int.Parse(strings[2]);

                    for (int i = 1; i <= times; i++)
                    {
                        int firstnumb = numbers[0];

                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = firstnumb;
                    }

                }
            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
