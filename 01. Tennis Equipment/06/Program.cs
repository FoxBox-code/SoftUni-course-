using System;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int starthieght = height - 30;
            int jumps = 0;
            bool isFailed = false;


            while (starthieght <= height) 
                {
                for (int i = 0; i <3; i++) 
                    {
                    int currentjum = int.Parse(Console.ReadLine());
                    jumps++;
                    if (currentjum > starthieght) {
                        starthieght += 5;
                        break;
                    }
                    if (i == 2) 
                        {
                        Console.WriteLine($"Tihomir failed at {starthieght}cm after {jumps} jumps.");
                        isFailed = true;
                    }
                    
                }
                if (isFailed) 
                    {
                    break;
                }

            }
            if (!isFailed) 
                
                {
                Console.WriteLine($"Tihomir succeeded, he jumped over {height}cm after {jumps} jumps.");
            
            
            }


            

        }
    }
}
