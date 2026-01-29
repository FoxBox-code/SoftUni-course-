using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Foods
{
    public class Cake : Dessert
    {
        private const double cakeGrams = 250;
        private const double cakeCalories = 1000;
        private const decimal cakePrise = 5m;
        public Cake(string name) : base(name, cakePrise, cakeGrams, cakeCalories)
        {

        }
    }
}
