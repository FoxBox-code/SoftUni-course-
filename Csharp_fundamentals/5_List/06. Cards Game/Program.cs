using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> P1Hand = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> P2Hand = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int smallestCount = 0;
            int sum = 0;
            int tunrs = 0;
            if (P1Hand.Count >= P2Hand.Count)
            {
                smallestCount = P2Hand.Count;
            }
            else
            {
                smallestCount = P1Hand.Count;
            }


             
            

                for (int i = 0; i < smallestCount; i++)
                {
                    int p1card = P1Hand[i];
                    int p2card = P2Hand[i];

                    if (p1card == p2card)
                    {
                        P1Hand.Remove(p1card);
                        P2Hand.Remove(p2card);
                    }
                    else if (p1card > p2card)
                    {
                        P1Hand.Remove(p1card);
                        P1Hand.Add(p1card);
                        P2Hand.Remove(p2card);
                        P1Hand.Add(p2card);
                    }
                    else if (p1card < p2card)
                    {
                        P2Hand.Remove(p2card);
                        P2Hand.Add(p2card);
                        P1Hand.Remove(p1card);
                        P2Hand.Add(p1card);
                    }
                    if (P1Hand.Count == 0 || P2Hand.Count == 0)
                   {
                    break;
                    

                     }

                    i--;
                    tunrs++;

                    

                }
            
            if (P2Hand.Count == 0)
            {
                foreach (int i in P1Hand)
                {
                    sum += i;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");

                
            }
            else
            {
                foreach (int i in P2Hand)
                {
                    sum += i;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
                

            }
            
        }
    }
}
