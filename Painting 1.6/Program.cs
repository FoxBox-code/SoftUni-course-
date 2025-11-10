using System;

namespace Painting_1._6
{
    internal class Program                                                                             
    {
        static void Main(string[] args)
        {
            double protectivenylon = 1.50;  // per m2
            double paint = 14.50; // per liter                                                                 10  11  4  8
            double paintthiner = 5.00; // per liter
            double bag = 0.40; 
            
            double needednylon = double.Parse(Console.ReadLine());
            double neededpaint = double.Parse(Console.ReadLine());
            double neededpaintthiner = double.Parse(Console.ReadLine());
            double hoursforthework = double.Parse(Console.ReadLine());
            double precent1 = 10 / 100;

            double valuenaylon = (needednylon + 2) * protectivenylon;
            double valuepaint = (neededpaint +precent1) * paint;
            double valuepainthiner = (neededpaintthiner * paintthiner);

            double totalvaluematerials = valuenaylon + valuepaint + valuepainthiner + bag;
            double  count = (11 +  10/100) * 14.50;
            double sumworkers = (totalvaluematerials * 30/100) * hoursforthework;
            double endsum = totalvaluematerials + sumworkers;

            Console.WriteLine(valuepaint);
        }
    }
}
                                                                                                     