using System;

namespace Basketball_1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualtraining = double.Parse(Console.ReadLine());
            double sneakers = annualtraining - (annualtraining * 40 / 100);
            double jersey = sneakers - (sneakers * 20 / 100);//175.2 RIGHT
            double basketball = jersey / 1/ 4  ;
            double accessories = basketball / 1 / 5;
            double Totalspendings = annualtraining + sneakers + jersey + basketball + accessories;
            Console.WriteLine(Totalspendings);   
        }
    }
}
