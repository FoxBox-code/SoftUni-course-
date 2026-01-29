using System;
using System.Linq;

namespace _02._Vowels_Count_with_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();
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
                if (Contains(vowels , ch))
                {
                    count++;
                }
            }
            return count;
        }
        static bool Contains(char[] arr, char searchedchar)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                char ch = arr[i];
                if (ch == searchedchar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
