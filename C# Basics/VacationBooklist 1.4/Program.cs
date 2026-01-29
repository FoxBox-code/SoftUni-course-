using System;

namespace VacationBooklist_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numpages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int pagesperH = numpages / pages;
            int daytoread = int.Parse(Console.ReadLine());
            int finaleanswer = pagesperH / daytoread;
            Console.WriteLine(finaleanswer);

        }
    }
}
