using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Calories.Ingridience
{
    public class Dough
    {
		private string flourType;
		private string bakingTechnique;
		private double weight;
		private double modifierForFlour;
		private double modiferForBacking;

		


		public Dough(string flourType, string backingTechnique, double weight)
		{
			FlourType = flourType.ToLower();
			BakingTechnique = backingTechnique.ToLower();
			Weight = weight;

            switch (FlourType)
            {
                case "white":
                    modifierForFlour = 1.5;
                    break;
                case "wholegrain":
                    modifierForFlour = 1.0;
                    break;


            }
            switch (BakingTechnique)
            {

                case "crispy":
                    modiferForBacking = 0.9;
                    break;
                case "chewy":
                    modiferForBacking = 1.1;
                    break;
                case "homemade":
                    modiferForBacking = 1.0;
                    break;

            }
            
        }
        public double ModifierForBacking
        {
            get { return modiferForBacking; }
            private set
            {

                modifierForFlour = value;
            }
        }



        public double Modifier
		{
			get { return modifierForFlour; }
			private set {
				
				modifierForFlour = value; }
		}


		public double Weight
		{
			get { return weight; }
            private set { 
				if(value <1 || value > 200)
				{
					throw new ArgumentException("Dough weight should be in the range [1..200].");
				}
				weight = value; }
		}


		public string BakingTechnique
		{
			get { return bakingTechnique; }
            private set
            {
				if(value != "crispy" && value != "chewy" && value != "homemade")
				{
					throw new ArgumentException("Invalid type of dough.");
				}
				bakingTechnique = value; }
		}


		public string FlourType
		{
			get { return flourType; }
            private set
            { 
				if(value != "white" && value != "wholegrain")
				{
					throw new ArgumentException("Invalid type of dough.");
				}
				flourType = value; }
		}
		public double Calories()
		{
            double calories = (2 * Weight) * modifierForFlour * modiferForBacking;
			return calories;
        }
		public override string ToString()
		{
			double calories = (2 * Weight) * modifierForFlour * modiferForBacking;
			return calories.ToString();
		}
	}
}
