using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double result = Divison(n1, n2);
            Console.WriteLine($"{result:F2}");






        }
        static double FactiroialDivisonfirstNumber(double n1)
        {
            double factorial = 1;
            for (int i = 1; i <= n1; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static double FactorialDivisonSecondNumber (double n2)
        {
            double factorial = 1;
            for (int i = 1; i <= n2; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static double Divison(double n1 , double n2)
        {
            double result = (double)FactiroialDivisonfirstNumber(n1) / FactorialDivisonSecondNumber(n2);
            return result;
        }

    }
}
