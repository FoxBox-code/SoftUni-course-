using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , uint> minerData = new Dictionary<string , uint>();

            string command;

            while((command = Console.ReadLine()) != "stop")
            {
                string key = command;
                uint value = uint.Parse(Console.ReadLine());

                if (!minerData.ContainsKey(key))
                {
                    minerData.Add(key, value);
                }
                else
                {
                    minerData[key] += value;
                }
            }

            foreach ( var item in minerData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
