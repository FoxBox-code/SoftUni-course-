using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChr = char.Parse(Console.ReadLine());
            char secondChr = char.Parse(Console.ReadLine());
            CharachterInRange(firstChr, secondChr);


        }


        static void CharachterInRange(char firstChr, char secondChr)
        {
            if (firstChr < secondChr)
            {
                for (int i = firstChr+1; i < secondChr; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else if (firstChr > secondChr)
            {
                for (int i = secondChr + 1; i < firstChr; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
