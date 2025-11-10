using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desiredsum = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < desiredsum) 
                {
                int currentsum = int.Parse(Console.ReadLine());

                sum += currentsum;

            }
            Console.WriteLine(sum); 
        
        }


    }
}
