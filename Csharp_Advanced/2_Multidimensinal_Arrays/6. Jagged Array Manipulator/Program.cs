using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jagged[i] = input;
            }

            for (int row = 0; row < jagged.Length-1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *=2;

                    }
                    
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                        

                    }
                    for (int col = 0; col < jagged[row+1].Length; col++)
                    {
                        
                        jagged[row + 1][col] /= 2;

                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(action[1]);
                int col = int.Parse(action[2]);
                double value = double.Parse(action[3]);

                if (action[0] == "Add")
                {
                    if (IsItInTheScope(jagged, row, col))
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (action[0] == "Subtract")
                {
                    if (IsItInTheScope(jagged, row, col))
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            foreach(double[] item  in jagged)
            {
                Console.WriteLine(string.Join(" ",item));
            }

        }

        private static bool IsItInTheScope(double[][] jagged, int row, int col)
        {
            return                  row >= 0
                                    && row < jagged.Length
                                    && col >= 0
                                    && col < jagged[row].Length;
        }
    }
}
