using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string EggSize = Console.ReadLine();
            string EggColor = Console.ReadLine();
            int numEggspack = int.Parse(Console.ReadLine());
            double price = 0;

            if (EggSize == "Large") 
                {
                switch (EggColor) 
                    {
                    case "Red": price = 16;break;
                    case "Green": price = 12;break;
                    case "Yellow": price = 9;break;

                
                     }

            }
            else if (EggSize == "Medium") 
                {
                switch (EggColor) {
                    case "Red": price = 13; break;
                    case "Green": price = 9; break;
                    case "Yellow": price = 7; break;


                }

            }
            else if (EggSize =="Small") 
                {
                switch (EggColor) 
                    {
                    case "Red": price = 9; break;
                    case "Green": price = 8; break;
                    case "Yellow": price = 5; break;


                }
            }
            double Totalmoney = price * numEggspack;
            Totalmoney = Totalmoney - (Totalmoney * 0.35);
            Console.WriteLine($"{Totalmoney:f2} leva.");
            

        }
    }
}
