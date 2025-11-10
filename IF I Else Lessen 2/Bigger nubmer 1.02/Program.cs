using System;

namespace Bigger_nubmer_1._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a  = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
