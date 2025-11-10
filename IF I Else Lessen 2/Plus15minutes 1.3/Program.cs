using System;

namespace Plus15minutes_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int fifteenminutes = 15;

            minutes = minutes + fifteenminutes;

            if(minutes>59) 
                {
                hours = hours + 1;
                minutes = minutes - 60;
                if (hours > 23) 
                    {
                    hours = 0;


                }

               
            }
            Console.WriteLine($"{hours}:{minutes:d2}");


        }
    }
}

