using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bevrages
{
    public abstract class HotBeverage : Beverage
    {
        protected HotBeverage(string name, decimal price, double mililliters) : base(name, price, mililliters)
        {
        }
    }
}
