using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Student
    {

        public Student()
        {
            Console.WriteLine("Object"); // This will aways execute

            Name = "Gorge";
            Age = 33;

            Grades = new List<double>();
        }

        public Student(string name, int age) : this()
        {
            Name = name;
            Age = age;
            Grades = new List<double>();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<double> Grades { get; set; }
    }
}
