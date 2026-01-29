using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Stack<int> clothesStack = new Stack<int>(
                Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );


            int rackCapacity = int.Parse(Console.ReadLine());
            int newRack = rackCapacity;

            int rackCounter = 1;

            if (clothesStack.Count > 50 || rackCapacity > 20)
            {
                return;
            }

            while(clothesStack.Count != 0)
            {
                rackCapacity -= clothesStack.Peek();

                if (rackCapacity < 0)
                {
                    rackCapacity = newRack;
                    rackCounter++;
                    continue;

                }
                clothesStack.Pop();
            }
            Console.WriteLine(rackCounter);

        }
    }
}
