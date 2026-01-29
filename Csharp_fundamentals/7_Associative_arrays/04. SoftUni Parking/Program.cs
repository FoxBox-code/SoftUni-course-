using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();



            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string theCommand = command[0];


                if (theCommand == "register")
                {
                    string key = command[1];
                    string value = command[2];

                    if (!parkingRegister.ContainsKey(key))
                    {
                        parkingRegister[key] = value;

                        Console.WriteLine($"{key} registered {value} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingRegister[key]}");
                    }
                }
                else if (theCommand == "unregister")
                {
                    string key = command[1];

                    if (parkingRegister.ContainsKey(key))
                    {
                        parkingRegister.Remove(key);

                        Console.WriteLine($"{key} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {key} not found");
                    }

                }


            }
            foreach (var item in parkingRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }














        }
    }
}
