using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length; i > 0; i--)
            {
                int totalsum = 0;
                Console.WriteLine(i);
                totalsum += i;
            }
        }
    }
}
