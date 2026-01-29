
using System;

namespace DefiningClasses;



public class StartUp
{
    private static void Main(string[] args) 
    {
        
         Family family = new Family();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            Person person = new Person(input[0], int.Parse(input[1]));


            family.Addperson(person);


        }

        Person oldest = family.GetOldestMember();

        var oldest2 = family.OlderThanThirty();

       //Console.WriteLine($"{oldest.Name} {oldest.Age}");
        
        foreach (Person person in oldest2.OrderBy(x=>x.Name)) // THIS SORTS BY ALHPEBETICAL ORDER REMEMBER THIS !!!!!!
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

        
        

        





    }
}


