using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            SmallestNmber(n1, n2, n3);

        }

        private static void SmallestNmber(int n1, int n2, int n3)
        {
            int smallest = int.MinValue;
            if (n1 <= n2 && n1 <= n3)
            {
                smallest = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                smallest = n2;
            }
            else if (n3 <= n1 && n3 <= n2)
            {
                smallest = n3;
            }
            Console.WriteLine(smallest);
        }
    }
}
