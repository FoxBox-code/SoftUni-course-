using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           

            for (int i = 0; i < array.Length; i++)
            {
                int currentnumber = array[i];
                bool bigNumber = true;

                for (int j = i +1; j < array.Length; j++)
                {
                    int nextnum = array[j];

                    if (nextnum >= currentnumber)
                    {
                        bigNumber = false;
                        break;
                    }

                }
                if (bigNumber)
                {
                    Console.Write($"{currentnumber} ");
                }
            }
        }
    }
}
