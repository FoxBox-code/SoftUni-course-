using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string demonNamePattern = @"[A-Za-z]";
            string damage = @"([\-\+\*\/])?\d(\.\d)?";
            string demon = "Azazel";



            int healthpoints = 0;
            double damageNum = 0;
            int multiplycount = 0;
            int divisoncount = 0;

            foreach (char ch in demon)
            {
                if (ch == '*')
                {
                    multiplycount++;
                }
                else if (ch == '/');
            }

            Regex demonregex = new Regex(demonNamePattern);
            Regex damagenums = new Regex(damage);

            MatchCollection namemach = demonregex.Matches(demon);
            MatchCollection lethality = damagenums.Matches(demon);


            StringBuilder nameBuilder = new StringBuilder();

            healthpoints = HP(healthpoints, namemach, nameBuilder);

            string dName = nameBuilder.ToString();

            foreach (Match m in lethality)
            {
                double num = double.Parse(m.Value);

                damageNum += num;
            }

            if(multiplycount > 0)
            {
                for (int i = 1; i <= multiplycount; i++)
                {
                    damageNum *= 2;
                }
            }

            Console.WriteLine(dName);
            Console.WriteLine(healthpoints);
            Console.WriteLine(damageNum);




        }

        private static int HP(int healthpoints, MatchCollection namemach, StringBuilder nameBuilder)
        {
            foreach (Match match in namemach)
            {
                char thiss = char.Parse(match.Value);
                int currnum = (int)thiss;

                healthpoints += currnum;

                nameBuilder.Append(match.Value);

            }

            return healthpoints;
        }
    }
}
