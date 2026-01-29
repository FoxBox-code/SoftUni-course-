using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Class_Box_Data
{
    public class Box
    {
		private double lenght;
		private double width;
		private double height;

		public Box(double lenght, double width, double height)
		{
			Lenght = lenght;
			Width = width;
			Height = height;
			
		}

		public double Height
		{
			get { return height; }
			private set {
				
				
					if(value <= 0)
					{
						throw new ArgumentException("Height cannot be zero or negative.");
					}
				
				
				height = value; }
		}


		public double Width
		{
			get { return width; }
            private set
            {
               
                
                    if (value <= 0)
                    {
                        throw new ArgumentException("Width cannot be zero or negative.");
                    }
                
                
                width = value; }
		}


		public double Lenght
		{
			get { return lenght; }
			private set {
                
                
                    if (value <= 0)
                    {
                        throw new ArgumentException("Length cannot be zero or negative.");
                    }
                
                
                lenght = value; }
		}

		public double SurfaceArea()
		{
			
			
            return 2 * (Lenght * Width) + 2 * (Lenght * Height) + 2 * (Width * Height);
        }
		public double LateralSurfaceArea()
		{
			
			return 2*(Lenght*Height) + 2*(Width * Height);
		}
		public double Volume()
		{
            return Lenght * Width * Height;

        }

    }
}
