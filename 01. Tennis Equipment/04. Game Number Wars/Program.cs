using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            string command = Console.ReadLine();
            int player1points = 0;
            int totalpoints1 = 0;
            int player2points = 0;
            int totalpoints2 = 0;


            while (command != "End of game") 
                {
                int player1card = int.Parse(command);
                int player2card = int.Parse(Console.ReadLine());
                if (player1card > player2card) 
                    {
                    player1points = player1card - player2card;
                    totalpoints1 = player1points + totalpoints1;

                }
                else if (player1card < player2card) 
                    {
                    player2points = player2card - player1card;
                    totalpoints2 = player2points + totalpoints2;


                }
                while (player1card == player2card) 
                    {
                    int player1card2 = int.Parse(Console.ReadLine());
                    int player2card2 = int.Parse(Console.ReadLine());

                    if ((player1card2 > player2card2)) 
                        {
                        Console.WriteLine($"Number wars!");
                        Console.WriteLine($"{player1} is winner with {totalpoints1} points");
                        return;
                    }
                    else if ((player1card2 > player2card2)) 
                        {
                        Console.WriteLine($"Number wars!");
                        Console.WriteLine($"{player2} is winner with {totalpoints2} points");
                        return;
                    }
                    
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"{player1} has {totalpoints1} points");
            Console.WriteLine($"{player2} has {totalpoints2} points");
        }
    }
}
