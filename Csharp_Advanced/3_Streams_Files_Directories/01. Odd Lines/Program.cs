using System;
using System.IO;
using System.Resources;

namespace _01._Odd_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using StreamReader sr = new StreamReader("../../../text.txt") ;

            string line = sr.ReadLine() ;
            int row = 1;

            while (line != null)
            {
                Console.WriteLine($"{row}.{line}") ;
                row++;
                line = sr.ReadLine() ;
            }
        }
    }
}
