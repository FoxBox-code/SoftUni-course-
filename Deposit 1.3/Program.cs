using System;

namespace Deposit_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositsum = double.Parse(Console.ReadLine());
            double termdeposit = double.Parse(Console.ReadLine());
            double annualprocent = double.Parse(Console.ReadLine());

            double intrest = depositsum * annualprocent/100;
            double intrestpermonth = intrest / 12;



            double sum = depositsum + termdeposit * (intrestpermonth);
            Console.WriteLine(sum);
        }
    }
}
