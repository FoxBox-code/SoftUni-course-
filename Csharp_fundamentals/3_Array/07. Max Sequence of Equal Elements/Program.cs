using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int equalcount = 1;
            int matchedNumb = 0;
            int maxcount = 0;
            int definitiveNum = 0;
            for (int i = 0; i < arrayNumbers.Length-1; i++)
            {
                
                if (arrayNumbers[i] != arrayNumbers[i + 1])
                {
                    equalcount = 1;
                    continue; //Numbers are not equal we go to the next index.
                    
                }
                if (arrayNumbers[i] == arrayNumbers[i + 1])
                {
                    matchedNumb = arrayNumbers[i];
                    equalcount++;
                }
                if (equalcount >= maxcount)
                {
                    maxcount = equalcount;
                    definitiveNum = matchedNumb;
                }
            }
            for (int i = 1; i <= maxcount; i++)
            {
                Console.Write(definitiveNum + " ");
            }
        }
    }
}
