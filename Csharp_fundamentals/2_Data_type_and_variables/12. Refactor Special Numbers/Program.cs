using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            int currentnumber = 0;

            bool toe = false;

            for (int ch = 1; ch <= num; ch++)

            {

                currentnumber = ch;

                while (ch > 0)

                {

                    sum += ch % 10;

                    ch = ch / 10;

                }

                toe = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", currentnumber, toe);

                sum = 0;

                ch = currentnumber;

            }
        }
    }
}
