using System;

namespace _01.Trains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbWagons = int.Parse(Console.ReadLine());

            int[] wagon = new int[numbWagons];

            int totalPasengers = 0;

            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                totalPasengers += wagon[i];
                Console.Write(wagon[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPasengers);
        }
    }
}
