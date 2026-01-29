using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numberPeople = int.Parse(Console.ReadLine());
            decimal capacity = int.Parse(Console.ReadLine());

            decimal total = Math.Ceiling(numberPeople / capacity);


            Console.WriteLine(total);
        }
    }
}
