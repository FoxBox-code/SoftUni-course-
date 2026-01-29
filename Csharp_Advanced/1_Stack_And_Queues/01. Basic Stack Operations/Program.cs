using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Stack<int> stackedNumbers = new Stack<int>();


            int numberOfPushed = numbers[0];

            int[] arrayPushed = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            if (numberOfPushed != arrayPushed.Length)
            {
                return;
            }
            else
            {
                foreach (var number in arrayPushed)
                {
                    stackedNumbers.Push(number);
                }
            }
            

            int poping = numbers[1];

            for (int i = 1; i <= poping; i++)
            {
                stackedNumbers.Pop();

            }

            int searchfor = numbers[2];

            if (stackedNumbers.Contains(searchfor))
            {
                Console.WriteLine("true");
            }
            else if (stackedNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stackedNumbers.Min());
            }
        }
    }
}
