using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder cypherMessege = new StringBuilder();




            
                

                for (int j = 0; j < input.Length; j++)
                {
                    int currentSymboll = input[j];
                    int cipher = currentSymboll + 3;

                cypherMessege.Append((char)cipher);
                }

            Console.WriteLine(cypherMessege);
            
            
        }
    }
}
