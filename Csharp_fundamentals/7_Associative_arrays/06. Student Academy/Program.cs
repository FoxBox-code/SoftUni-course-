using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string , List<double>> avrageGrade = new Dictionary<string , List<double>>();

            for (int i = 1; i <= n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!avrageGrade.ContainsKey(student))
                {
                    avrageGrade.Add(student, new List<double>());
                    avrageGrade[student].Add(grade);
                }
                else
                {
                    avrageGrade[student].Add(grade);

                }
            }

            foreach( var item in avrageGrade)
            {
                double avrageGrades = item.Value.Average();
                if (avrageGrades < 4.50)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{item.Key} -> {avrageGrades:f2}");
                }
            }
        }
    }
}
