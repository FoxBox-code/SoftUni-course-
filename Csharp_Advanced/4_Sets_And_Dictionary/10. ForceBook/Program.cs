/*using System.Text;

SortedDictionary<Dictionary<string, int>, string> forceBook = new SortedDictionary<Dictionary<string, int>, string>();


string command;

while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    string[] input = command.Split(" ");


    if (input.Contains("|")) // Force side to Force User
    {
        string side = input[0];
        StringBuilder name = new StringBuilder();
        for (int i = 2; i < input.Length; i++)
        {
            name.Append(input[i]);
        }
        string fullName = name.ToString();
        if (!forceBook.ContainsValue(fullName))
        {
            forceBook.Add(fullName, new Dictionary<string, int>());
        }
        if (!forceBook[fullName].ContainsKey(side))
        {
            forceBook[fullName].Add(side, 0);

        }
        forceBook[fullName][side]++;
    }
    else if (input.Contains("->")) //ForceUser to ForceSide
    {
        string side = input[input.Length - 1];
        StringBuilder name = new StringBuilder();

        for (int i = 0; i < input.Length - 2; i++)
        {
            name.Append(input[i] + " ");
        }
        string fullName = name.ToString();

        if (!forceBook.ContainsKey(fullName))
        {
            forceBook.Add(fullName, new Dictionary<string, int>());
            forceBook[fullName].Add(side, 0);
            forceBook[fullName][side]++;
        }
        else
        {
            string currentSide = forceBook[fullName].Keys;

        }

    }
}*/