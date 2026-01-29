HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();



int[] twolengths = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < twolengths[0]; i++)
{
    first.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < twolengths[1]; i++)
{
    second.Add(int.Parse(Console.ReadLine()));
}

foreach (int i in first)
{
    if (first.Contains(i) && second.Contains(i))
    {
        Console.Write(i + " ");
    }
}