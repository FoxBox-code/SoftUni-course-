using System;

namespace Bonus_points_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wholenumber = int.Parse(Console.ReadLine());
            
            double bonus = 0.0;

            if (wholenumber < 100) 
                {
                bonus = 5;


            }
            else if (wholenumber > 1000) 
                {

                bonus = (int)wholenumber * 0.1;

            }

            else 
            {
                bonus = (int)wholenumber * 0.2;



            }
            if (wholenumber % 2 == 0) 
                {

                bonus = bonus + 1;

            }
            else if (wholenumber % 10 == 5) 
                {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(wholenumber + bonus);


            }
        }

    }

