using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            StringBuilder validName = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currentword = input[i];



                if (currentword.Length >= 3 && currentword.Length <= 16)
                {
                    bool nameIsValid = true;
                    foreach (char currentCharachter in currentword)
                    {

                        if (!(char.IsLetterOrDigit(currentCharachter) || currentCharachter == '_' || currentCharachter == '-'))
                        {
                            nameIsValid = false;
                            break;
                        }

                    }
                    if (nameIsValid)
                    {
                        validName.AppendLine(currentword);
                    }
                }
            }
            Console.WriteLine(validName);
        }
    }
}
