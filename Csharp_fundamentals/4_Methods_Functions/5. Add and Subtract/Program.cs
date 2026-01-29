using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = SubtractionResult(n1, n2, n3);
            Console.WriteLine(result);



        }
        static int SumOfTwoNumbers(int n1 , int n2)
        {
            return n1 + n2;
        }
        static int SubtractionResult(int n1, int n2, int n3)
        {
            return SumOfTwoNumbers(n1, n2) - n3;
        }
    }
}
