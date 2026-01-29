using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyIds = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "End")
            {

                string[] commandArray = command
                    .Split("->");

                string company = commandArray[0].Trim();
                string id = commandArray[1].Trim();
                    
                if (!companyIds.ContainsKey(company))
                {
                    companyIds.Add(company, new List<string>());
                    companyIds[company].Add(id);
                }
                else
                {
                    if (companyIds[company].Contains(id))
                    {
                        continue;
                    }
                    else
                    {
                        companyIds[company].Add(id);
                    }
                }
                

                
            }
            foreach (var details in companyIds)
            {
                Console.WriteLine(details.Key);

                for (int i = 0; i < details.Value.Count; i++)
                {
                    Console.WriteLine($"-- {details.Value[i]}");
                }
            }
        }
    }
}
