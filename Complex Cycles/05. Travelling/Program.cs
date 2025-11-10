using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            double moneyneeded;
            double savings=0;
            bool flagisup = false;

            while (true) 
                {

                


                while ((destination = Console.ReadLine()) != "Endd") 
                    {
                    if (destination == "End") 
                        {
                        return;

                    }

                    moneyneeded = double.Parse(Console.ReadLine());

                    double saved = 0;
                    while (moneyneeded >= saved) {
                        savings = double.Parse(Console.ReadLine());


                        saved = saved + savings;
                        if (moneyneeded <= saved) {
                            Console.WriteLine($"Going to {destination}!");
                            flagisup = true;
                            break;

                        }

                    }
                    if (flagisup) {
                        break;

                    }



                }
            }
        }
    }
}
