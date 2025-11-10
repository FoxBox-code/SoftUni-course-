using System;

namespace wtf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            decimal priceOfTiket = 0;

            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Friday" ) 
                {
                priceOfTiket = 12m;
                Console.WriteLine(priceOfTiket);    


            }
            else if (dayOfTheWeek == "Wednesday" || dayOfTheWeek== "Thursday") 
                {
                priceOfTiket = 14m;
                Console.WriteLine (priceOfTiket);
                    

            }
             else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday") 
                {
                priceOfTiket = 16m;
                Console.WriteLine(priceOfTiket);

            }


        }
    }
}
