using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfBall = int.Parse(Console.ReadLine());
            int totalpoints = 0;
            int redcount = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int othercolor = 0;
            for (int i = 1; i <= numOfBall; i++) 
                {
                string ballcolor = Console.ReadLine();
                int points = 0;
                switch (ballcolor) 
                    {
                    case "red": points = 5;redcount++; break;
                    case "orange": points = 10;orange++; break;
                    case "yellow": points = 15;yellow++; break;
                    case "white": points = 20;white++; break;
                        
                    case "black": totalpoints = totalpoints/2;black++; break;
                        



                }
                if (ballcolor != "red" && ballcolor != "orange" && ballcolor != "yellow" && ballcolor != "white" && ballcolor != "black") {
                    othercolor++;
                }
                totalpoints = totalpoints + points;

            }
            Console.WriteLine($"Total points: {totalpoints}");
            Console.WriteLine($"Red balls: {redcount}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {othercolor}");
            Console.WriteLine($"Divides from black balls: {black}");
                

        }
    }
}
