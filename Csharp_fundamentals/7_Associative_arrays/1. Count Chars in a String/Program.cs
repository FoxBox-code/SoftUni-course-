using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ');

            Dictionary<char, int> lettercount = new Dictionary<char, int>();



            for (int i = 0; i < strings.Length; i++)
            {
                string currentword = strings[i];

                for (int j = 0; j < currentword.Length; j++)
                {
                    char currentcar = currentword[j];
                    int count = 1;

                    if (!lettercount.ContainsKey(currentcar))
                    {
                        lettercount.Add(currentcar,count);
                    }
                    else
                    {
                        lettercount[currentcar]++;
                    }
                }

            }
            foreach (var letter in lettercount)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
