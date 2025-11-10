using System;

namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            decimal priceOfProduct = 0;

            if (city == "Sofia") 
                {
                if (product == "coffee") 
                    {
                    priceOfProduct = 0.50m;
                
                
                
                
                }
                else if ( product == "water") 
                    {
                    priceOfProduct = 0.80m;
                
                
                }
                else if ( product == "beer") 
                    {
                    priceOfProduct = 1.20m;
                
                
                
                }
                else if ( product == "sweets") 
                    {
                    priceOfProduct = 1.45m;

                
                
                }
                else if ( product == "peanuts") 
                    {
                    priceOfProduct = 1.60m;
                
                }

            }
            else if (city == "Plovdiv") 
                {
                if (product == "coffee") 
                    {
                    priceOfProduct = 0.40m;




                }
                else if (product == "water") 
                    {
                    priceOfProduct = 0.70m;


                }
                else if (product == "beer") 
                    {
                    priceOfProduct = 1.15m;



                }
                else if (product == "sweets") 
                    {
                    priceOfProduct = 1.30m;



                }
                else if (product == "peanuts") 
                    {
                    priceOfProduct = 1.50m;

                }

            }
            else if (city == "Varna") 
                {
                if (product == "coffee") 
                    {
                    priceOfProduct = 0.45m;




                }
                else if (product == "water") 
                    {
                    priceOfProduct = 0.70m;


                }
                else if (product == "beer") 
                    {
                    priceOfProduct = 1.10m;



                }
                else if (product == "sweets") 
                    {
                    priceOfProduct = 1.35m;



                }
                else if (product == "peanuts") 
                    {
                    priceOfProduct = 1.55m;

                }

            }

            decimal price = priceOfProduct * (decimal)quantity;
            Console.WriteLine(price);

        }
    }
}
