using System;
using System.Security.Claims;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int numstudents = int.Parse(Console.ReadLine());
            decimal lightsaberprice = decimal.Parse(Console.ReadLine());
            decimal robeprice = decimal.Parse(Console.ReadLine());
            decimal beltprice = decimal.Parse(Console.ReadLine());
            decimal discountbelt = numstudents / 6;

            decimal forsaber = Math.Ceiling((numstudents * 0.10m)+ numstudents)*lightsaberprice;
            
            

            decimal forrobe = robeprice * numstudents;
            decimal forbelt = 0;

            //if (numstudents %6 == 0)
            {
                //discountbelt = numstudents / 6;
               // forbelt = (numstudents - discountbelt) * beltprice;
                
            }
            //else
            {
                
            }
            decimal spendings = forsaber + forrobe + ((numstudents - discountbelt)*beltprice);

            if (money >= spendings)
            {
                Console.WriteLine($"The money is enough - it would cost {spendings:f2}lv.");

            }
            else
            {
                spendings -= money;
                Console.WriteLine($"John will need {spendings:f2}lv more.");
            }

        }
    }
}
