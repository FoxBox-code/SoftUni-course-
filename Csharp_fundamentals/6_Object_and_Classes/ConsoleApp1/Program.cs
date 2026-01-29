using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Name = "Loki";
            dog.Breed = "Huski";
            dog.Age = 4;

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Breed);
            Console.WriteLine(dog.Age);
            dog.Bark();

           

            Dog dog2 = new Dog();

            dog2.Name = "Sigurd";
            dog2.Breed = "Actual Wolf";
            dog2.Age = 1000;
            

            Console.WriteLine(dog2.Name);
            Console.WriteLine(dog2.Breed);
            Console.WriteLine(dog2.Age);
            dog2.Bark();


            Random random = new Random();//Random is a class given to use by using (using System library)

            int randomnum = random.Next(0,51);// This generates a random number 51 not included

            Console.WriteLine(randomnum);

        }
    }
}
