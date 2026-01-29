using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());

            firstnumber += second;
            firstnumber /= third;
            firstnumber *= forth;

            Console.WriteLine(firstnumber);


        }
    }
}
