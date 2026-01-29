using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueNumbers = new Queue<int>();


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
                    queueNumbers.Enqueue(number);
                }
            }


            int poping = numbers[1];

            for (int i = 1; i <= poping; i++)
            {
                queueNumbers.Dequeue();

            }

            int searchfor = numbers[2];

            if (queueNumbers.Contains(searchfor))
            {
                Console.WriteLine("true");
            }
            else if (queueNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queueNumbers.Min());
            }
        }
    }
}
