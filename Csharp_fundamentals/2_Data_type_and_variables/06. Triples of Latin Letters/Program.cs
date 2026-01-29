using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numb; i++)
            {
                for (int j = 0; j < numb; j++)
                {
                    for (int k = 0; k < numb; k++)
                    {
                        char firstchar = (char)('a' + i);
                        char secondchar = (char)('a' + j);
                        char thirdchar = (char)('a' + k);
                        Console.WriteLine($"{firstchar}{secondchar}{thirdchar}");
                    }
                }
            }
            
        }
    }
}
