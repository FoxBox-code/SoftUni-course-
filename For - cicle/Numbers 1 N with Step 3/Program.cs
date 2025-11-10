using System;

namespace Numbers_1_N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numb; i+=3) 
                {
                Console.WriteLine(i);
            }
            
        }   
    }       
}           
            