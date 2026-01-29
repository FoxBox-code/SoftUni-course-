using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {

                string[] commands = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string order = commands[0];

                if (order == "Add")
                {
                    int numb = int.Parse(commands[1]);
                    numbers.Add(numb);

                }
                else if (order == "Insert")
                {
                    int numb = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    if (index > numbers.Count || index < 0)
                    {
                        continue;
                    }

                    numbers.Insert(index, numb);

                }
                else if (order == "Remove")
                {
                    int numb = int.Parse(commands[1]);

                    if (numb > numbers.Count || numb < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(numb);

                }
                else if (order == "Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int firstnumb = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstnumb);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {

                            int lastnumb = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastnumb);
                        }
                    }
                }

            }
            Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
