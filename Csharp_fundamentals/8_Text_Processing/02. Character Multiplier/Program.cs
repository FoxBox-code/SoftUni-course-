using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] twoWords = Console.ReadLine()
                .Split(" ");



            string one = twoWords[0];
            string two = twoWords[1];

            int totalSum = 0;
            totalSum = SumOfTheWords(one, two, totalSum);

            Console.WriteLine(totalSum);

            // to find the shortest length we can use Math.Min (stringone , stringtwo);

        }

        private static int SumOfTheWords(string one, string two, int totalSum)
        {
            if (one.Length == two.Length)
            {
                for (int i = 0; i < two.Length; i++)
                {
                    int symbolFromOne = one[i];
                    int symbolFromTwo = two[i];


                    int sum = symbolFromOne * symbolFromTwo;
                    totalSum += sum;
                }
            }
            else
            {
                if (one.Length > two.Length)
                {
                    for (int i = 0; i < two.Length; i++)
                    {
                        int symbolFromOne = one[i];
                        int symbolFromTwo = two[i];


                        int sum = symbolFromOne * symbolFromTwo;
                        totalSum += sum;
                    }
                    for (int i = two.Length; i < one.Length; i++)
                    {
                        int num = one[i];

                        totalSum += num;
                    }
                }
                else
                {
                    for (int i = 0; i < one.Length; i++)
                    {
                        int symbolFromOne = one[i];
                        int symbolFromTwo = two[i];


                        int sum = symbolFromOne * symbolFromTwo;
                        totalSum += sum;
                    }
                    for (int i = one.Length; i < two.Length; i++)
                    {
                        int num = two[i];

                        totalSum += num;
                    }

                }

            }

            return totalSum;
        }
    }
}
