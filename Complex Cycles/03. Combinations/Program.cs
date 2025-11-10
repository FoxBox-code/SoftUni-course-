using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;

            for (int x1 = 0; x1 <= n; x1++) 
                {
                for (int y1 = 0; y1 <= n; y1++) 
                    {
                    for (int z1 = 0; z1 <= n; z1++) 
                        {
                        int sum = x1 + y1 + z1;
                        if (n==x1+y1+z1) 
                            {
                            result++;

                        }


                    }

                }

            }
            Console.WriteLine(result);
            
            
        }
    }
}
