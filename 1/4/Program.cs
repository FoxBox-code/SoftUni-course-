using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodKG = 12.45;


            int numcats = int.Parse(Console.ReadLine());
            double totalfoodeaten = 0;
            int smallcats = 0;
            int mediumcats = 0;
            int largecats = 0;


            for (int i = 1; i <= numcats; i++) {
                double foodeatengrams = double.Parse(Console.ReadLine());

                totalfoodeaten += foodeatengrams;
                if (foodeatengrams >= 100 && foodeatengrams < 200) 
                    {
                    smallcats++;


                } 
                else if (foodeatengrams >= 200 && foodeatengrams < 300) 
                    {
                    mediumcats++;
                }   
                else if (foodeatengrams >= 300 && foodeatengrams <= 400) 
                    {
                    largecats++;
                }
                

            }
            double foodinkg = totalfoodeaten / 1000;
            double spendperday = foodinkg * foodKG;

            Console.WriteLine($"Group 1: {smallcats} cats.");
            Console.WriteLine($"Group 2: {mediumcats} cats.");
            Console.WriteLine($"Group 3: {largecats} cats.");
            Console.WriteLine($"Price for food per day: {spendperday:f2} lv.");
        }
    }
}
