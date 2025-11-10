using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            
           for (int i =1; n>=sum;)
                { 

                Console.WriteLine(sum);

                sum = sum * 2 + 1;




            }
        }
    }
}
