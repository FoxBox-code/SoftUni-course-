using System;

namespace _06._High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desirtedheight = double.Parse(Console.ReadLine());
            double jumps = 0;
            double startingheight = desirtedheight - 30;
            int tries = 3;
            bool flag = false;

            double jumped = 0; 

            while (desirtedheight > jumped) 
                {

                for (jumped = double.Parse(Console.ReadLine()); jumped <= startingheight;) 
                        {
                    tries--;
                    jumps++;
                    
                    if (tries == 0) 
                        {
                        flag = true;
                        break;

                    }
                    jumped =double.Parse(Console.ReadLine());





                }

                if (flag) 
                    {
                    break;
                }
                jumps++;
                if (jumped > startingheight) {
                    startingheight += 5;
                    tries = 3;
                }
                
                
            }
            if (flag) {
                Console.WriteLine($"Tihomir failed at {startingheight}cm after {jumps} jumps.");
            }
            else {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desirtedheight}cm after {jumps} jumps.");
            }

            

        }
    }
}
