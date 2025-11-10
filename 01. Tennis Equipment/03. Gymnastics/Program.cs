using System;

namespace _03._Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string gamemode = Console.ReadLine();
            double diffuclty = 0;
            double execution = 0;
            double gainedpoints = 0;

            if (country== "Russia") 
                {
                switch (gamemode) 
                    {
                    case "ribbon": diffuclty = 9.100; execution = 9.400; break;
                    case "hoop": diffuclty = 9.300; execution = 9.800; break;
                    case "rope": diffuclty = 9.600; execution = 9.000; break;

                        


                }


            }
            else if (country == "Bulgaria") 
                {
                switch (gamemode) 
                    {
                    case "ribbon": diffuclty = 9.600; execution = 9.400; break;
                    case "hoop": diffuclty = 9.550; execution = 9.750; break;
                    case "rope": diffuclty = 9.500; execution = 9.400; break;
                        
                }
            }
            else if (country == "Italy") 
                {
                switch (gamemode) {
                    case "ribbon": diffuclty = 9.200; execution = 9.500; break;
                    case "hoop": diffuclty = 9.450; execution = 9.350; break;
                    case "rope": diffuclty = 9.700; execution = 9.150; break;
                        
                }
            }
            gainedpoints = diffuclty + execution;
            double remaining = (20 - gainedpoints);
            double procentege = (remaining / 20) * 100;

            Console.WriteLine($"The team of {country} get {gainedpoints:f3} on {gamemode}. ");
            Console.WriteLine($"{procentege:f2}%");
        }
    }
}
