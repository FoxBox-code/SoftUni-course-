using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayone = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arraytwo = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < arraytwo.Length; i++)
            {
                for (int j = 0; j < arrayone.Length; j++)
                {
                    if (arraytwo[i] == arrayone[j])
                    {
                        Console.Write(arrayone[j] + " ");
                    }
                }
            }


        }
    }
}
