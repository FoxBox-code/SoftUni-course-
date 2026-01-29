using System;
using System.Linq;

namespace _02.Vowels_count_with_function_Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelcount = VoewlCount(input);
            Console.WriteLine(vowelcount);

        }

        private static int VoewlCount(string text)
        {
            int count = 0;
            char[] vowels = { 'a', 'i', 'o', 'u', 'y', 'e' };
            foreach (char ch in text.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
