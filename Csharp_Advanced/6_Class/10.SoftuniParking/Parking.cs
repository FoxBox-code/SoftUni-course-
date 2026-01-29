using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{



    public class Parking
    {
        private Dictionary<string, Car> cars = new Dictionary<string, Car>();
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();

        }
        public int Count => cars.Count;

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return $"Car with that registration number, already exists!";
            }

            if (cars.Count >= capacity)
            {
                return $"Parking is full!";
            }

            cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registerNumber)
        {
            if (!cars.ContainsKey(registerNumber))
            {
                return $"Car with that registration number, doesn't exist!";

            }
            cars.Remove(registerNumber);
            return $"Successfully removed {registerNumber}";
        }
        public Car GetCar(string registerNumber)
        {
            return cars[registerNumber];
        }


    }
}
