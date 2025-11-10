using System;

namespace _04._Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalpoints = 301;
            string player = Console.ReadLine();
            bool flag = false;
            int shots = 0;
            int failedshots = 0;
            string area;
            
            while ((area = Console.ReadLine()) != "Retire") 
                {
                area = area;
                
                int points = int.Parse(Console.ReadLine());

                switch (area) 
                    {
                    case "Single": points= points*1; break;
                    case "Double": points = points*2; break;
                    case "Triple": points = points * 3; break;


                }
                
                if (totalpoints < points) 
                    {
                    failedshots++;
                    continue;
                }
                else if (totalpoints >= points) 
                    {
                    totalpoints = totalpoints - points;
                    shots++;
                }
                if (totalpoints == 0) 
                    {
                    break;
                }
                
            }
            if (area == "Retire") {
                Console.WriteLine($"{player} retired after {failedshots} unsuccessful shots.");
            }
            else {
                Console.WriteLine($"{player} won the leg with {shots} shots.");
            }
        }
    }
}
