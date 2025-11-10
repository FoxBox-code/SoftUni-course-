using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int max = int.MinValue;
            int min = int.MaxValue;
            while ((command=Console.ReadLine()) != "Stop") 
                {
                int inputnum = int.Parse(command);
                if (inputnum > max) {
                    max = inputnum;
                }
                if (inputnum < min) 
                    {
                    min = inputnum;

                }

            }
            Console.WriteLine(max);
        }
    }
}
