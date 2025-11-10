using System;

namespace Swimming__1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordseconds = double.Parse(Console.ReadLine());
            double distancemetters = double.Parse(Console.ReadLine());
            double timeinseconds = double.Parse(Console.ReadLine());

            double needssmiw = distancemetters * timeinseconds;
            double twelvesecadd = distancemetters / 15 * 12.5;
            double Totaltime = needssmiw + twelvesecadd;

            if (recordseconds < Totaltime) {
                double diffrence = Totaltime - recordseconds;
                Console.WriteLine($"No, he failed! He was {diffrence:F2} seconds slower." );
                
            }
            else {
                
                Console.WriteLine($"Yes, he succeeded! The new world record is {Totaltime:F2} seconds.");
                
                
            }

        }
    }
}
