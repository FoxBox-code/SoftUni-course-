using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nMesseges = int.Parse(Console.ReadLine());

            string pattern = @"^[^\@\-\!\:\>]*?\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(?<population>\d+)[^\@\-\!\:\>]*?\!(?<attacktipe>A|D)\![^\@\-\!\:\>]*?\-\>(?<soldiercount>\d+)[^\@\-\!\:\>]*?$";

            Regex regex = new Regex(pattern);

            List<string> destroyedPlanets = new List<string>();
            List<string> attackedPlanets = new List<string>();


            for (int i = 1; i <= nMesseges; i++)
            {
                string decriptedMessege = Console.ReadLine();

                string messege = MessegeDecription(decriptedMessege);


                Match match = regex.Match(messege);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attackType = match.Groups["attacktipe"].Value;

                    if (attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                    else
                    {
                        attackedPlanets.Add(planet);
                    }
                }
            }

            PlanetStatus(destroyedPlanets, attackedPlanets);

        }

        private static void PlanetStatus(List<string> destroyedPlanets, List<string> attackedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string MessegeDecription(string decriptedMessege)
        {
            StringBuilder encriptedmessege = new StringBuilder();
            int symbollDown = 0;

            foreach(char ch in decriptedMessege.ToLower())
            {
                if (ch == 't' || ch == 's' || ch == 'a' || ch == 'r')
                {
                    symbollDown++;
                }
            }

            foreach (char ch in decriptedMessege)
            {
                int decriptedSymboll = (int)ch - symbollDown;
                encriptedmessege.Append((char)decriptedSymboll);

            }

            return encriptedmessege.ToString();


        }
    }
}
