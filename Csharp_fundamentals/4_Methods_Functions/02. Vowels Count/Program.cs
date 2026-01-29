using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = VoWSum(input);
            Console.WriteLine(result);
        }

        static int VoWSum(string input)
        {
            int sumOfVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char character = char.Parse(input[i].ToString());

                if (character == 'A' || character == 'E' || character == 'O' || character == 'Y' || character == 'I' || character == 'U')
                {
                    sumOfVowels++;
                }
                if (character == 'a' || character == 'e' || character == 'o' || character == 'y' || character == 'i' || character == 'u')
                {
                    sumOfVowels++;
                }

            }
            return sumOfVowels;  //when we use return. Return can only bring one value to the fold.
        }
    }
}
