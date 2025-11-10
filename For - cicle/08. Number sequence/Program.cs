using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumber = int.Parse(Console.ReadLine());

            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;


            for (int i = 1; i <= totalNumber; i++) 
                {
                int currentnumber = int.Parse(Console.ReadLine());

                if (currentnumber > maxnumber) 
                    {
                    maxnumber = currentnumber;
                }
                if (currentnumber < minnumber) 
                    {
                    
                    minnumber = currentnumber;
                }
                
            }
            Console.WriteLine($"Max number:" + maxnumber);

            Console.WriteLine($"Min number:" + minnumber);


        }

    }
}
