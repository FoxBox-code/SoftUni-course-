using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int biggestOrder = int.MinValue;

            int[] inLineOrrdes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int>orders = new Queue<int>(inLineOrrdes);


            Console.WriteLine(orders.Max());
            while(orders.Count != 0)
            {
                int foodNeeded = orders.Peek();
                

                if (foodNeeded <= foodQuantity)
                {
                    if (biggestOrder < orders.Peek())
                    {
                        biggestOrder = orders.Peek();
                    }
                    foodQuantity -= foodNeeded;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }

            }
            
           
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
        }
    }
}
