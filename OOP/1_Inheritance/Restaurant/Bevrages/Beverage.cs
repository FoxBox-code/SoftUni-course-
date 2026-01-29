using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bevrages
{
    public abstract class Beverage : Product
    {
        public Beverage(string name, decimal price, double mililliters) : base(name, price)
        {
            Mililliters = mililliters;
        }

        public double Mililliters { get; set; }
    }
}
