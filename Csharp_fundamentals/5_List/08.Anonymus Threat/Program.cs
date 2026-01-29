using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Anonymus_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdarg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string order = cmdarg[0];

                if (order == "merge")
                {
                    int startindex = int.Parse(cmdarg[1]);
                    int endinsex = int.Parse(cmdarg[2]);

                    FindIfIndexisValid(words, ref startindex, ref endinsex);

                    string mergedText = string.Empty;
                    MergedTExt(words, startindex, endinsex, mergedText);

                }
                else if (order == "divide")
                {
                    int index = int.Parse(cmdarg[1]);
                    int partitions = int.Parse(cmdarg[2]);

                    string currentword = words[index];
                    int substringlength = currentword.Length / partitions;
                    int lastsubstringLength = currentword.Length -(partitions - 1 ) * substringlength;

                    List<string> partitionList = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        int desiredlength = substringlength;

                        if (desiredlength == partitions - 1)
                        {
                            desiredlength = lastsubstringLength;
                        }

                        char[] newPartitionarray = currentword
                            .Skip(i * substringlength)
                            .Take(desiredlength)
                            .ToArray();
                        string newpartition = String.Join("", newPartitionarray);
                        partitionList.Add(newpartition);

                    }
                    words.RemoveAt(index);
                    words.InsertRange(index , partitionList);
                }
            }
            Console.WriteLine(String.Join(" ", words));
        }

        private static void MergedTExt(List<string> words, int startindex, int endinsex, string mergedText)
        {
            for (int i = startindex; i <= endinsex; i++)
            {
                string currentword = words[startindex];
                mergedText += currentword;
                words.RemoveAt(startindex);

            }
            words.Insert(startindex, mergedText);
            
        }

        private static void FindIfIndexisValid(List<string> words, ref int startindex, ref int endinsex)
        {
            if (startindex < 0)
            {
                startindex = 0;
            }
            if (startindex >= words.Count)
            {
                startindex = words.Count - 1;
            }
            if (endinsex <= 0)
            {
                endinsex = 0;
            }
            if (endinsex > words.Count)
            {
                endinsex = words.Count - 1;
            }
        }
    }
}
