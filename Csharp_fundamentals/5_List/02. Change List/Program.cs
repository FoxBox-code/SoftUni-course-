using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] orders = command.Split();
                string order = orders[0];

                if (order == "Delete")
                {
                    int number = int.Parse(orders[1]);
                    if (numbers.Contains(number))
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.Remove(number);
                        }
                    }
                }
                else if ( order == "Insert")
                {
                    int number =int.Parse (orders[1]);
                    int index = int.Parse(orders[2]);

                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
