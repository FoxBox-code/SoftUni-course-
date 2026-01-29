using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,List<string>> corseList = new Dictionary<string,List<string>>();


            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] input = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = input[0].Trim();
                string student = input[1];

                if (!corseList.ContainsKey(course))
                {
                    corseList.Add(course, new List<string>());
                    corseList[course].Add(student);
                        
                        
                }
                else
                {
                    
                    corseList[course].Add(student);

                }
            }
            foreach(var item in corseList)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"--{item.Value[i]}");
                }
            }
        }
    }
}
