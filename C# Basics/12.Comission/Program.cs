using System;

namespace _12.Comission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;

            if (city == "Sofia") 
                {
                if (sales > 0 && sales <= 500) {
                    comission = 0.05;
                }
                else if (sales > 500 && sales <= 1000) {
                    comission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000) {
                    comission = 0.08;
                }
                else if (sales > 10000) 
                    {
                    comission = 0.12;

                }
                comission = comission * sales;
                Console.WriteLine($"{comission:F2}");
            }
            else if (city == "Varna") 
                {
                if (sales > 0 && sales <= 500) {
                    comission = 0.045;
                }
                else if (sales > 500 && sales <= 1000) {
                    comission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000) {
                    comission = 0.10;
                }
                else if (sales > 10000) {
                    comission = 0.13;
                }
                comission = comission * sales;
                Console.WriteLine($"{comission:F2}");
            }
            else if (city == "Plovdiv") 
                {
                if (sales > 0 && sales <= 500) {
                    comission = 0.055;
                    comission = comission * sales;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (sales > 500 && sales <= 1000) {
                    comission = 0.08;
                    comission = comission * sales;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (sales > 1000 && sales <= 10000) {
                    comission = 0.12;
                    comission = comission * sales;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (sales > 10000) {
                    comission = 0.145;
                    comission = comission * sales;
                    Console.WriteLine($"{comission:F2}");
                }
                else 
                {
                    Console.WriteLine("error");
                }
                
            }
            else 
            {
                Console.WriteLine("error");
            }


            

        }
    }
}
