using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsepower, double fuel) : base(horsepower, fuel)
        {

        }
        protected override double FuelConsumption => 10;
    }
}
