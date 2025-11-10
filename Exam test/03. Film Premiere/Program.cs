using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string Moviename = Console.ReadLine();


                string consumable = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            int drink =0;
            int popcorn =0;
            int menu = 0;

            if (Moviename == "John Wick") 
                {
                drink = 12;
                popcorn = 15;
                menu = 19;
                if (consumable == "Drink") 
                    {
                    int price = drink * tickets;
                    Console.WriteLine($"Your bill is {price:F2} leva.");

                }
                else if (consumable == "Popcorn") 
                    {
                    int price = popcorn * tickets;
                    Console.WriteLine($"Your bill is {price:F2} leva.");


                }
                else if (consumable == "Menu") 
                    {
                    int price = tickets * menu;
                    Console.WriteLine($"Your bill is {price:F2} leva.");
                }


            }
            else if (Moviename =="Star Wars") 
                {
                drink = 18;
                popcorn = 25;
                menu = 30;
                if (consumable == "Popcorn") 
                    {
                    if (tickets >=4) 
                        {
                        double price = tickets * popcorn;
                        double totalprice = price - (0.3 * price);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva.");

                        
                    }
                    else {
                         double price = tickets * popcorn;
                        Console.WriteLine($"Your bill is {price:F2} leva.");
                    }


                }
                else if (consumable == "Drink") 
                    {
                    if (tickets >= 4) {
                        double price = tickets * drink;
                        double totalprice = price - (0.3 * price);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva.");


                    }
                    else {
                        double price = tickets * drink;
                        Console.WriteLine($"Your bill is {price:F2} leva.");
                    }

                }
                else if (consumable == "Menu") {
                    if (tickets >= 4) {
                        double price = tickets * menu;
                        double totalprice = price - (0.3 * price);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva.");


                    }
                    else {
                        double price = tickets * menu;
                        Console.WriteLine($"Your bill is {price:F2} leva.");
                    }
                }
                

            }
            else if (Moviename == "Jumanji") 
                {
                drink = 9;
                popcorn = 11;
                menu = 14;
                if (consumable == "Menu")
                    {
                    if (tickets == 2) 
                        {
                        double price = tickets * menu;
                        double totalprice = price - (price * 0.15);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva. ");


                    }
                    else {
                        double price = (tickets * menu);
                        Console.WriteLine($"Your bill is {price:F2} leva. ");

                    }

                }
                else if (consumable == "Drink") 
                    {
                    if (tickets == 2) {
                        double price = tickets * drink;
                        double totalprice = price - (price * 0.15);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva. ");


                    }
                    else {
                        double price = (tickets * drink);
                        Console.WriteLine($"Your bill is {price:F2} leva. ");

                    }
                }
                else if (consumable == "Popcorn") {
                    if (tickets == 2) {
                        double price = tickets * popcorn;
                        double totalprice = price - (price * 0.15);
                        Console.WriteLine($"Your bill is {totalprice:F2} leva. ");


                    }
                    else {
                        double price = (tickets * popcorn);
                        Console.WriteLine($"Your bill is {price:F2} leva. ");

                    }
                }
            }

        }
    }
}
