using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            while ((number = Console.ReadLine()) != "END")
            {
                string backwards = ReverseStringWithoutInbuiltMethod(number);

                if ( number == backwards)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            
        }
        private static string ReverseStringWithoutInbuiltMethod(string stringInput)
        {
            // Reverse using While loop  
            string reversestring = "";
            int length;

            length = stringInput.Length-1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            return reversestring;

        }
    }
}
