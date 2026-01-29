using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
		private int horsePower;
		private double fuel;

		public Vehicle(int horsePower , double fuel)
		{
			HorsePower = horsePower;
			Fuel = fuel;
		}
		public double Fuel
		{
			get { return fuel; }
			private set { fuel = value; }
		}

		public int HorsePower
		{
			get { return horsePower; }
			private set { horsePower = value; }
		}
		protected virtual double FuelConsumption { get => 1.25;  }

		public virtual void Drive(double kilometers)
		{
			Fuel -= kilometers * FuelConsumption;
		}
	}
}
