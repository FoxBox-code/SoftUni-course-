using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= n; i++)
                {
                leftSum = leftSum + int.Parse(Console.ReadLine());

                // TODO: read and calculate the rightSum
                if (leftSum == rightSum)
                    {


                    Console.WriteLine("Yes, sum = " + leftSum);
                }
                else {
                    int diff = Math.Abs(rightSum - leftSum);
                    Console.WriteLine("No, diff = " + diff);
                }
            }
        }

    }
    }

