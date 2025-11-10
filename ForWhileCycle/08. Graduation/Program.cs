using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameofStudent = Console.ReadLine();

            int classes = 12;
            int year = 1;
            double grade;
            double totalgrade = 0;
            int repeat = 0;

            while (classes >= year) 
                {
                
                 grade = double.Parse(Console.ReadLine());
                year++;

                if (grade < 4) {
                    repeat++;
                    year--;
                    
                }
                
                if (repeat > 1) 
                    {
                    Console.WriteLine($"{nameofStudent} has been excluded at {year} grade");
                    break;

                }
                


                totalgrade = totalgrade + grade;
                if (12 < year) 
                    {
                    double avragegrade = totalgrade / (12+repeat);
                    Console.WriteLine($"{nameofStudent} graduated. Average grade: {avragegrade:F2}");

                }


                




            }
           
        
        
        
        
        
        
        
        
        }
    }
}
