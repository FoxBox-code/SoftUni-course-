using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicnum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int n1 = start; n1 <= end; n1++) 
                {
                for (int n2 = start; n2 <= end; n2++) 
                    {
                    counter++;

                    int currentsum = n1 + n2;
                    if (currentsum == magicnum) 
                        {
                        Console.WriteLine($"Combination N:{counter} ({n1} + {n2} = {magicnum})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicnum}");


        }
    }
}
