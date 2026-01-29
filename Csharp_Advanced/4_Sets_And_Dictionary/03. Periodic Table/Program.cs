using System.Collections.Immutable;

SortedSet<string> elements = new SortedSet<string>();


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] el = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < el.Length; j++)
    {
        elements.Add(el[j]);
    }

}




Console.WriteLine(String.Join(" ",elements));