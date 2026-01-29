using System;
using System.Collections.Generic;

namespace _05._Students_2_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Student> listOfSutends = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arrayInput = input.Split(' ');

                string firstName = arrayInput[0];
                string secondName = arrayInput[1];
                int age = int.Parse(arrayInput[2]);
                string town = arrayInput[3];

                bool exists = false;

                Student student = new Student(firstName, secondName, age, town);

                foreach (var currentstudent in listOfSutends)
                {
                    if (currentstudent.FirstName == firstName && currentstudent.LastName == secondName)
                    {
                        currentstudent.Age = student.Age;
                        currentstudent.Town = student.Town;
                        exists = true;

                    }
                }
                // bool exists = listOfSutends
                                //.Any(x => x.FirstName == FirstName && x.SecondName == SecondName);

                if (!exists)
                {
                    listOfSutends.Add(student);
                }

            }

            string desiredTown = Console.ReadLine();

            foreach (Student theStudent in listOfSutends)
            {
                if (theStudent.Town == desiredTown)
                {
                    Console.WriteLine($"{theStudent.FirstName} {theStudent.LastName} is {theStudent.Age} years old.");
                }
            }
        }




        public class Student
        {
            public Student(string firstName, string lastName, int age, string town)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Town = town;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Town { get; set; }


        }
    }
}
