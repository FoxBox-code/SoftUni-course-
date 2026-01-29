using System;
using System.Linq;

namespace _10.Lady_Bugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize empy field 
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];


            //2. Spawn ladybugs on the valid indexes.
            // This collection remains unchanged!
            int[] initialisedIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialisedIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    //Valid index initialize lady bug on this index
                    field[index] = 1;
                }

            }
            //3. Game Starts
            string command;
                while ((command = Console.ReadLine()) != "end")

            { 
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugindex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLengTh = int.Parse(cmdArgs[2]);

                 //3.1 Validate if ladybugindex is inside the index
                 if (ladybugindex < 0 || ladybugindex >= field.Length)
                {
                    //Invalid index -- nothing happens.
                    continue;
                }

                 //3.2 Validate if Ladibugindex contains ladybugs
                 if (field[ladybugindex] == 0)
                {
                    //There is no ladybug there --- nothing happens.
                    continue;
                }

                //3.3 Try  to proceed move
                //Right ladybug moves fly length (ladybugindex + flylength)
                //Left lady bug moves fly length (ladybugindex - (flylength *-1)

                field[ladybugindex] = 0;
                if (direction == "left")
                {
                    flyLengTh *= -1;// To go left we need to subtract so we change flylength exc; we have 5 moves left (5*-1) becomes (-5) and we move back 5 spaces.

                }

                //0 Right 1 => 0 + 1 = 1;
                //1 Left 1 => 1 + (-1) = 0;
                int nextIndex = ladybugindex + flyLengTh;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    //Precalculate next step if ladybug steps on onether of her kind
                    nextIndex += flyLengTh;
                }
                //There are two possiblities
                //Variant a indicates : nextIndex is calculated somewhere on the fild
                //Variant b indicates : nextIndex has left the length of the playing field
                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //variant b Ladybug has left the playing field so we move to new instructions
                    continue;
                }
                //variant a Ladybug land on a valid next index.
                field[nextIndex] = 1;



                 }
            Console.WriteLine(String.Join(" ", field));

        }
    }
}
