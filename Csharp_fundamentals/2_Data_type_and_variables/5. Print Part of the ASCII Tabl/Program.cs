using System;

namespace _5._Print_Part_of_the_ASCII_Tabl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startnumb = int.Parse(Console.ReadLine());
            int endnumb = int.Parse(Console.ReadLine());
            for (int i = startnumb; i <= endnumb; i++)
            {
                char thiss = (char)i;
                Console.Write(thiss+ " ");
            }
            
        }
    }
}
