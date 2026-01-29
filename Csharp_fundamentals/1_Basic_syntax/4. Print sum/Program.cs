using System;

namespace _4._Print_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int statnubmer = int.Parse(Console.ReadLine());
            int finishnumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = statnubmer; i <= finishnumber; i++)
            {
                Console.Write(i + " ");
                sum+=i;
            }
            Console.WriteLine("");
            Console.WriteLine("Sum: " + sum );
        }
    }
}
