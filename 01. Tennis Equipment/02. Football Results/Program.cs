using System;

namespace _02._Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 = (Console.ReadLine());
            string result2 = (Console.ReadLine());
            string result3 = (Console.ReadLine());
            int wins = 0;
            int loses = 0;
            int draws = 0;

            char Homeside1 = result1[0];
            char Awayside1 = result1[2];
            
            
            if (Homeside1 > Awayside1) {
                wins++;
                

                
            }
            else if (Homeside1 < Awayside1) 
                {
                loses++;
                

            }
            else {
                draws++;
                
            }
            char Homeside2 = result2[0];
            char Awayside2 = result2[2];

            if (Homeside2 > Awayside2) {
                wins++;
                


            }
            else if (Homeside2 < Awayside2) {
                loses++;
                

            }
            else {
                draws++;
               
            }
            
            char Homeside3 = result3[0];
            char Awayside3 = result3[2];

            if (Homeside3 > Awayside3) {
                wins++;
                


            }
            else if (Homeside3 < Awayside3) {
                loses++;
                

            }
            else {
                draws++;
                
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {loses} games.");
            Console.WriteLine($"Drawn games: {draws}");


        }
    }
}
