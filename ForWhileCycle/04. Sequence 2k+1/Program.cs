using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            int numbinorder =0 ;
            
            while (n > numbinorder) 
                {
                 
                numbinorder = numbinorder * 2 + 1;
                if (numbinorder > n) {
                    break;
                }
                Console.WriteLine(numbinorder); 
                

            }

                
        }
    }
}
