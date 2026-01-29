using System;

namespace _11.Fruit_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double numOfFruits = double.Parse(Console.ReadLine());
            double prise = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") 
                {
                if (fruit == "banana")
                    {
                    prise = 2.50;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "apple") 
                    {
                    prise = 1.20;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "orange") 
                    {


                    prise = 0.85;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "grapefruit") 
                    {
                    prise = 1.45;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "kiwi") 
                    {
                    prise = 2.70;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");

                }
                else if (fruit == "pineapple") 
                    {
                    prise = 5.50;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "grapes") {
                    prise = 3.85;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else {
                    Console.WriteLine("error");

                }
            }
            else if (day =="Saturday" || day == "Sunday") 
                {
                if (fruit == "banana") {
                    prise = 2.70;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "apple") {
                    prise = 1.25;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "orange") {


                    prise = 0.90;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "grapefruit") {
                    prise = 1.60;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "kiwi") {
                    prise = 3.00;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");

                }
                else if (fruit == "pineapple") {
                    prise = 5.60;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else if (fruit == "grapes") {
                    prise = 4.20;
                    prise = prise * numOfFruits;
                    Console.WriteLine($"{prise:F2}");
                }
                else {
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
