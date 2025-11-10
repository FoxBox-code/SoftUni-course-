using System;

namespace _01._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualpayment = double.Parse(Console.ReadLine());

            double shoesprice = annualpayment-(annualpayment * 0.40);
            double jersey = shoesprice - (shoesprice * 0.20);
            double ball = jersey / 4;
            double stuff = ball / 5;

            double totalequpmentcost = shoesprice + jersey + ball + stuff + annualpayment;
            Console.WriteLine($"{totalequpmentcost:F2}");

        }
    }
}
