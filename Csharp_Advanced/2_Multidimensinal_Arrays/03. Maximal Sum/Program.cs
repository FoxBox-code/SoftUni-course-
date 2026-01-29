using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];
            int[,] result = new int[3, 3];

            int maxSum = 0;

            Read(sizes, matrix);
            maxSum = GetMaximumSumOf3x3(sizes, matrix, result, maxSum);
            Console.WriteLine($"Sum = {maxSum}");
            
            Display(result);

        }

        private static void Display(int[,] result)
        {
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    Console.Write(result[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int GetMaximumSumOf3x3(int[] sizes, int[,] matrix, int[,] result, int maxSum)
        {
            for (int row = 0; row < sizes[0] - 2; row++)
            {
                for (int col = 0; col < sizes[1] - 2; col++)
                {
                    int sum = 0;
                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        for (int rows = 0; rows < 3; rows++)
                        {
                            for (int cols = 0; cols < 3; cols++)
                            {
                                result[rows, cols] = matrix[row + rows, col + cols];
                            }
                        }
                    }




                }
            }

            return maxSum;
        }

        private static void Read(int[] sizes, int[,] matrix)
        {
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = input[col];

                }
            }

        }
    }
}
