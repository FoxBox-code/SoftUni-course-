using System;
using System.Linq;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[array[0], array[1]];

            string snake = Console.ReadLine();
            int i = 0;
            int count = 1;

            for (int row = 0; row < array[0]; row++)
            {
                if (count % 2 == 1)
                {
                    for (int col = 0; col < array[1]; col++,i++)
                    {
                        if (i >= snake.Length)
                        {
                            i = 0;
                        }
                        matrix[row, col] = snake[i].ToString();
                        
                        
                    }
                    
                    count++;
                }
                else
                {
                    for (int col = array[1]-1; col >= 0; col--, i++)
                    {
                        if (i >= snake.Length)
                        {
                            i = 0;
                        }
                        matrix[row, col] = snake[i].ToString();
                        

                    }
                    
                    count++;
                }

                for (int X = row; X <= row; X++)
                {
                    for (int Y = 0; Y < array[1]; Y++)
                    {
                        Console.Write(matrix[X, Y]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
