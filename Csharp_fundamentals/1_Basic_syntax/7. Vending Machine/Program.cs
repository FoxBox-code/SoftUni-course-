using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Start;
            double enteredcoin;
            double sum=0;
            string End;
            string product;
            double costs = 0;
            while ((Start = Console.ReadLine()) != "Start")
            {
                enteredcoin = double.Parse(Start);
                if (enteredcoin != 0.1 && enteredcoin != 0.2 && enteredcoin != 0.5 && enteredcoin != 1 && enteredcoin != 2)
                {
                    Console.WriteLine($"Cannot accept {enteredcoin}");
                    continue;
                }
                sum += enteredcoin;


            }
            while ((End = Console.ReadLine()) != "End")
            {
                product = (End);

                switch (product)
                {
                    case "Nuts": costs = 2.00 ; break;
                    case "Water": costs = 0.7; break;
                    case "Crisps": costs = 1.50; break;
                    case "Soda": costs = 0.8;break;
                    case "Coke": costs = 1.0; break;
                    default: Console.WriteLine("Invalid product"); continue; 
                        
                        


                }
                
                
                if (sum >= costs)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= costs;
                }
                else if (sum < costs)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                
            }
            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
