using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Calories.Ingridience
{
    public class Topping
    {
		private string toppingsType;
		private double calorieModifier;
		private double grams;

		



		public Topping(string toppingsType,double grams)
		{
			ToppingsType = toppingsType;
			Grams = grams;

			switch (ToppingsType.ToLower())
			{
				case "meat": calorieModifier = 1.2;
					break;
				case "veggies": calorieModifier = 0.8;
					break ;
				case "cheese": calorieModifier = 1.1;
					break;
				case "sauce": calorieModifier = 0.9;
					break;

            }
		}
        public double Grams
        {
            get { return grams; }
            set {
				
				if(value < 0 || value > 50)
				{
					throw new ArgumentException($"{value} weight should be in the range [1..50].");
				}
				grams = value; }
        }


        public double CalorieModifier
		{
			get { return calorieModifier; }
			set { 
				
				calorieModifier = value; }
		}

		public string ToppingsType
		{
			get { return toppingsType; }
			set {
				string toLower = value.ToLower();
				if (toLower != "meat" && toLower != "veggies" && toLower != "cheese" && toLower != "sauce")
				{
					throw new ArgumentException($"Cannot place {value} on top of your pizza.");
				}
				toppingsType = value; }
		}
		public double Calories()
		{
            double calories = (2 * grams) * calorieModifier;
			return calories;
        }

		public override string ToString()
		{
			double calories = (2*grams) * calorieModifier;
			return calories.ToString();
		}
	}
}
