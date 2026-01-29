using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int rotationcount = rotations % arraynumbers.Length;//This is optional but very important it optimises the code to work better if modul devision
                                                                //find that rotation can equal zero its very beneficial.


            for (int i = 1; i <= rotationcount; i++)
            {
                int firstnumb = arraynumbers[0];
                for (int j = 0; j < arraynumbers.Length - 1; j++)
                {
                    arraynumbers[j] = arraynumbers[j+1];
                }
                arraynumbers[arraynumbers.Length-1] = firstnumb;
            }
            Console.WriteLine(String.Join(" ",arraynumbers));

        }
    }
}
