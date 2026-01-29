using System;

namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dice dice = new Dice();

            dice.DiceNumber = 6;


            dice.Roll();
            Console.WriteLine(dice.Name);

            while (true)
            {
                int currentNumber = dice.RollTurn;
                Console.WriteLine(currentNumber);
                if (currentNumber == 6)
                {
                    
                    break;
                }
                

            }

        }
    }
}
