using System;

namespace Area_of_figure_1._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double  square1 = double.Parse(Console.ReadLine());
                double Shape1 = square1 * square1;
                Console.WriteLine($"{Shape1:F3}");

            }

            else if (shape == "rectangle")
            {
                double  rectangle1 = double .Parse(Console.ReadLine());
                double rectangle2 = double .Parse(Console.ReadLine());
                double Shape2 = rectangle1 *  rectangle2;
                Console.WriteLine("{0:F3}", Shape2);

            }
            else if (shape == "circle")
            {
                double circle1 = double .Parse(Console.ReadLine());
                double Shape3 = circle1 * circle1 * Math.PI;
                Console.WriteLine("{0:F3}", Shape3);
            }
            else if (shape == "triangle")
            {
                double triangleside = double .Parse(Console.ReadLine());
                
                double triangleheight = double .Parse(Console.ReadLine());
                double Shape4 =  (double) 1/2 *triangleside * triangleheight ;
                Console.WriteLine("{0:F3}", Shape4);

            }
        }
    }
}
