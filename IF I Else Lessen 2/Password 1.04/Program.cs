using System;

namespace Password_1._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwords =  Console.ReadLine();
            
            if (passwords == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Wrong password!");

            }

        }
    }
}
