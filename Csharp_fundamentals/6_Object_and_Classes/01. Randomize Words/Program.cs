using System;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                

                int randomNum = random.Next(0,wordsArray.Length);

                string currentWord = wordsArray[i];
                string nextWord = wordsArray[randomNum];

                wordsArray[i] = nextWord;
                wordsArray[randomNum] = currentWord;

            }
            Console.WriteLine(String.Join(Environment.NewLine, wordsArray));
        }
    }
}
