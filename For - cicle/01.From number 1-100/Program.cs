using System;

namespace _01.From_number_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());


            for (int i = numb; i >= 1; i--) 
                {
                Console.WriteLine(i);

            }
        }
    }
}
