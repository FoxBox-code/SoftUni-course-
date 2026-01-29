using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Dice
    {
         public int DiceNumber { get; set; }

        public string Name
        {
            get
            {
                return $"DiceNumber {DiceNumber}";
            }
        }



        public  int  Roll()
        {

            Random random = new Random();

            int rollTurn = random.Next(1, DiceNumber + 1);

            return rollTurn;
        }

        public int RollTurn
        {
            get
            {
                return Roll();
            }
        }

    }
}
