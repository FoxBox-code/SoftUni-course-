using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[] firstarray = new int[n];
            int[] secondarray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] number = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstnum = number[0];
                int secondnum = number[1];

                if (i % 2 != 0)
                {
                    firstarray[i-1] = firstnum;
                    secondarray[i-1] = secondnum;
                }
                else
                {
                    secondarray[i-1] = firstnum;
                    firstarray[i-1] = secondnum;
                }
            }
            Console.WriteLine(String.Join(" ", firstarray));
            Console.WriteLine(String.Join(" ", secondarray));


            


        }
    }
}
