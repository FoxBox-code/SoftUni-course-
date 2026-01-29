using System;

namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;
            double days = years * 365.2422;
            int dayss = (int)days;
            double hours = dayss * 24;
            double minutes = hours * 60;
            Console.WriteLine($"{century} centuries = {years:f0} years = {dayss:f0} days = {hours:f0} hours = {minutes:f0} minutes");


        }
    }
}
