using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            decimal headsetprice = decimal.Parse(Console.ReadLine());
            decimal mouseprice = decimal.Parse(Console.ReadLine());
            decimal keyboard = decimal.Parse(Console.ReadLine());
            decimal displayprice = decimal.Parse(Console.ReadLine());

            int headsetdestyoed = lostgames / 2;
            int mousedestroyed = lostgames / 3;
            int keyboarddestyoed = lostgames / 6;
            int displaydestroyed = lostgames / 12;

            decimal expneses = (headsetdestyoed*headsetprice) + (mousedestroyed*mouseprice) + (keyboarddestyoed*keyboard) + (displaydestroyed * displayprice);
            Console.WriteLine($"Rage expenses: {expneses:f2} lv.");


        }
    }
}
