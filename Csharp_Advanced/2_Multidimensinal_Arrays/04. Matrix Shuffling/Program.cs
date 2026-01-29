using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];
            Read(sizes, matrix);


            string commands;

            while((commands = Console.ReadLine()) != "END")
            {
                string[] action = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string swap = action[0];

                if (action.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row = int.Parse(action[1]);
                int col = int.Parse(action[2]);
                int rowSwap = int.Parse(action[3]);
                int colSwap = int.Parse(action[4]);
                if (swap != "swap" || sizes[0] < row || sizes[0] < rowSwap || sizes[1] < col || sizes[1] < colSwap || row < 0 || rowSwap < 0 || col < 0 || colSwap < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string firstElement = (matrix[row,col]);
                string secondElement = (matrix[rowSwap,colSwap]);

                matrix[row,col]=secondElement.ToString();
                matrix[rowSwap,colSwap]=firstElement.ToString();

                for (int i = 0; i <= rowSwap; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j] + " ");
                    }
                    Console.WriteLine();
                }


                

            }
        }

        private static void Read(int[] sizes, string[,] matrix)
        {
            for (int row = 0; row < sizes[0]; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    
                    .ToArray();
                    
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = input[col];

                }
            }
        }

        
    }
}
