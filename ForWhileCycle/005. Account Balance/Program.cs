using System;

namespace _005._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalsumOfMoney = 0;
            string nomoremoney ;
            double increese;
            while ((nomoremoney = Console.ReadLine()) !="NoMoreMoney")
                {
                increese = double.Parse(nomoremoney);
                
                
                if (increese < 0) 
                    {
                    Console.WriteLine("Invalid operation!");
                    
                    
                    break;
                }
                Console.WriteLine($"Increase: { increese:F2}");
                totalsumOfMoney = totalsumOfMoney + increese;
                
              
                   
            }
            Console.WriteLine($"Total: { totalsumOfMoney}");

        }
    }
}
