using System;

namespace _04.Password_Validation_Altern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string givenPassword = Console.ReadLine();
            bool isLengthValid = IsPasswordLengthValid(givenPassword);
            bool isAphaMerical = IsAlphaNumericValid(givenPassword);
            bool isThereMoreThanTwoDigits = IsThereMoreThanTwoDigits(givenPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isAphaMerical)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isThereMoreThanTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && isAphaMerical && isThereMoreThanTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool IsPasswordLengthValid(string password)
        {
            return password.Length >=6 && password.Length <=10;
        }

        static bool IsAlphaNumericValid(string password)
        {
            foreach(char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsThereMoreThanTwoDigits(string password)
        {
            int digitcounter = 0;
            foreach(char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitcounter++;
                }
            }
            return digitcounter >= 2;
        }
    }
}
