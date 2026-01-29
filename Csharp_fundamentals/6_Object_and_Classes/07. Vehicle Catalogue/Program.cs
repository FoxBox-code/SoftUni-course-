using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input; 

            Catalog catalog = new Catalog();


            while ((input = Console.ReadLine()) != "end")
            {
                string[] viechleINfo = input.Split("/");

                string viechleType = viechleINfo[0];
                string viechleBrand = viechleINfo[1];
                string viechleModel = viechleINfo[2];
                int value = int.Parse(viechleINfo[3]); //Hp or Wgh;

                if (viechleType == "Truck")
                {
                    Truck truck = new Truck (viechleBrand, viechleModel, value);
                    catalog.Trucks.Add (truck);

                }
                else if (viechleType == "Car")
                {
                    Car car = new Car (viechleBrand, viechleModel, value);
                    catalog.Cars.Add (car); 
                    

                }


            }

            Console.WriteLine("Cars:");

            foreach( var eachviechle in catalog.Cars.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{}: {Model} - {Horse Power}hp");
            }

            Console.WriteLine("Trucks:");


            foreach( var eachviiechle in catalog.Trucks.OrderBy(x=>x.Brand))
            {

            }
        }


        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }

        }

        public class Car
        {
            public Car  (string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }


        }

        public class Catalog
        {
            public List<Car> Cars { get; set; }

            public List<Truck> Trucks { get; set; }

        }
    }
}
