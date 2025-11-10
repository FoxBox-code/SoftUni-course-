using System;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Cinemacapacity = int.Parse(Console.ReadLine());
            string End;
            int tiketprice = 5;
            int totalprice = 0;
            int totalviews = 0;
            int payment = 0;
            while ((End = Console.ReadLine()) != "Movie time!") 
                {
                
                int viewers = int.Parse(End);
                if (viewers % 3 == 0) 
                    {
                    payment = (viewers * 5) - 5;

                }
                else {
                    payment = viewers *5;
                }
                totalviews= viewers+ totalviews;
                totalprice = payment + totalprice;
                if (totalviews >= Cinemacapacity) {
                    Console.WriteLine($"The cinema is full.");
                    Console.WriteLine($"Cinema income - {totalprice} lv.");
                    return;
                }
                    

            }
            if (totalviews >= Cinemacapacity) {
                Console.WriteLine($"The cinema is full.");
                Console.WriteLine($"Cinema income - {totalprice}");
            }
            else if (totalviews < Cinemacapacity) 
                {
               int seats = Cinemacapacity - totalviews;
                Console.WriteLine($"There are {seats} seats left in the cinema.");
                
                Console.WriteLine($"Cinema income - {totalprice} lv.");

            }
        }
    }
}
