using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPouring = int.Parse(Console.ReadLine());
            int maxLiters = 255;
            int start = 0;

            for (int i = 1; i <= numPouring; i++)
            {
                int addingwater = int.Parse(Console.ReadLine());
                start += addingwater;
                if (start > maxLiters)
                {
                    start -= addingwater;
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(start);
        }
    }
}
