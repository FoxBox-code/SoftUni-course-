using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeforPictures = int.Parse(Console.ReadLine());
            int numscenes = int.Parse(Console.ReadLine());
            int snecelenght = int.Parse(Console.ReadLine());

            double preperatinon = timeforPictures * 0.15;
            double camerawork = numscenes * snecelenght;
            double TotalneededTime = camerawork + preperatinon;
            

            if (timeforPictures > TotalneededTime) 
                {
                int timeleft = timeforPictures - (int)TotalneededTime;
                Console.WriteLine($"You managed to finish the movie on time! You have {timeleft} minutes left!");
            }
            else {
                int noteneoghttime = (int)TotalneededTime - timeforPictures;
                Console.WriteLine($"Time is up! To complete the movie you need {noteneoghttime} minutes.");
            }
        }
    }
}
