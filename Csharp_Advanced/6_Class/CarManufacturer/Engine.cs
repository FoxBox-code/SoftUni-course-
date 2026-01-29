using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
		private int horspePower; // typing propfull automaticly makes the field and the property.
        private double cubicCApacity;

        public Engine(int horspePower, double cubicCApacity)
        {
            this.horspePower = horspePower;
            this.cubicCApacity = cubicCApacity;
        }

        public double CubicCapacity
		{
			get { return cubicCApacity; }
			set { cubicCApacity = value; }
		}

        public int Horsepower
        {
            get { return horspePower; }
            set { horspePower = value; }
        }




    }
}
