using System;
using System.Security.Cryptography.X509Certificates;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenInput = Console.ReadLine();
            int conditioncheck = 0;
            LengthValidation(givenInput, ref conditioncheck);
            SymbollCheck(givenInput, ref conditioncheck);
            DigitCheck(givenInput, ref conditioncheck);
            if (conditioncheck == 3)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static void LengthValidation(string givenInput, ref int conditioncheck)
        {
            int letterscount = 0;
            foreach (char c in givenInput)
            {

                char currentcharachter = c;
                letterscount++;

            }
            if (letterscount >= 6 && letterscount <= 10)
            {
                conditioncheck++;

            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static void SymbollCheck(string givenINput, ref int conditioncheck)
        {
            foreach (int i in givenINput)
            {
                int currentletter = i;
                if (currentletter >= 48 && currentletter <= 57 || currentletter >= 65 && currentletter <= 90 || currentletter >= 97 && currentletter <= 122)
                {

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return;
                }
            }
            conditioncheck++;
        }
        static void DigitCheck(string givenInput, ref int conditioncheck)
        {
            int digitcount = 0;
            foreach (char i in givenInput)
            {
                int currentletter = i;
                if (currentletter >= 48 && currentletter <= 57)
                {
                    digitcount++;
                }

            }
            if (2 > digitcount)
            {
                Console.WriteLine("Password must have at least 2 digits");

            }
            conditioncheck++;
        }
    }
}
