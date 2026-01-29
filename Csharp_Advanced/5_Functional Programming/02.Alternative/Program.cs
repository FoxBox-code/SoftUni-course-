Action<string[], string> print = (strings, title) =>
{
    foreach (string s in strings)
    {
        Console.WriteLine($"{title} {s}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(names, "Sir");
 