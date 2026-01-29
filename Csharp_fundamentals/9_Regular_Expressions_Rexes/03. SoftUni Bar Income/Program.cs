using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\%\|\$\.]*?\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*$";

            string command;

            decimal totalincome = 0;

            Regex regex = new Regex(pattern);

            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(command);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalprice = price * count;

                    totalincome += totalprice;

                    Console.WriteLine($"{customer}: {product} - {totalprice:f2}");
                }

            }
            Console.WriteLine($"Total income: {totalincome:f2}");
        }
    }
}
