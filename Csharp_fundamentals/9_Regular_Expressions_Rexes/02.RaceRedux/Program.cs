using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.RaceRedux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , int > athletes = new Dictionary<string, int>();


            string[] runnersArray = Console.ReadLine()
                .Split(", ");


            foreach (string runner in runnersArray)
            {
                if (!athletes.ContainsKey(runner))
                {
                    athletes[runner] = 0;
                }
            }
            string command = string.Empty;

            while((command = Console.ReadLine()) != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string kmPattern = @"\d";

                int distancerun = 0;
                

                StringBuilder nameBuilder = new StringBuilder();
                

                Regex nameregex = new Regex(namePattern);
                Regex kmreggex = new Regex(kmPattern);

                MatchCollection namematch = nameregex.Matches(command);

                if (namematch.Count == 0)
                {
                    continue;
                }

                foreach (Match match in namematch)
                {
                    nameBuilder.Append(match.Value);
                }
                string currentContender = nameBuilder.ToString();

                if (athletes.ContainsKey(currentContender))
                {
                    MatchCollection distance = kmreggex.Matches(command);

                    foreach (Match km in distance)
                    {
                        int num = int.Parse(km.Value);
                        distancerun += num;

                    }
                    athletes[currentContender] += distancerun;
                }
                


            }
            athletes = athletes
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, y => y.Value);


            Console.WriteLine($"1st place: {athletes.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {athletes.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {athletes.Keys.ElementAt(2)}");



            //dict = dict
            //.OrderByDescending(x => x.Value)
            //.ToDictionary(x => x.Key, y => y.Value);




        }
    }
}
