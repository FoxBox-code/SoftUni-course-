using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFloors = int.Parse(Console.ReadLine());
            int numVenus = int.Parse(Console.ReadLine());

            for (int f = numFloors; f >= 1; f--) 
                {
                for (int v = 0; v < numVenus; v++) 
                    {
                     if (f == numFloors) 
                        {
                        Console.Write($"L{f}{v} ");
                        

                    }
                    else if  (f % 2 == 0) 
                        {
                        Console.Write($"O{f}{v} ");
                        

                    }
                    else if (f % 2 == 1) 
                        {
                        Console.Write($"A{f}{v} ");



                    }


                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
