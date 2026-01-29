using System;
using System.Collections.Generic;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();


            for (int i = 1; i <= numb; i++)
            {
                string[] strings = Console.ReadLine().Split("_");

                string typelist = strings[0];
                string name = strings[1];
                string time = strings[2];

                Songs song = new Songs(typelist, name, time);
                songs.Add(song);
            }

            string list = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Songs currentsong = songs[i];

                if (list == "all")
                {
                    Console.WriteLine(currentsong.Name);

                }
                else if (list == currentsong.TypeList)
                {
                    Console.WriteLine(currentsong.Name);
                }
            }
        }

    }
    internal class Songs
    {
        public Songs(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
}
