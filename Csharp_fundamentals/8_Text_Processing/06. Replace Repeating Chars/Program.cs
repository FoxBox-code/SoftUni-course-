using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sting = new StringBuilder();

            char currentCharachter = input[0];
            Console.Write(currentCharachter);

            for (int i = 1; i < input.Length; i++)
            {
               currentCharachter = input[i];
                char previus = input[i - 1];


                

                

                if (previus!= currentCharachter)
                {
                    Console.Write(currentCharachter);
                }





            }
        }
    }
}
