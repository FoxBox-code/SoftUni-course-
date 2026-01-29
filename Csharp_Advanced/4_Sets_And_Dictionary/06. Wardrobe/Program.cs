Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split("->");
    string color = input[0];
    string[] items = input[1].Split(",",StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < items.Length; j++)
    {
        string item = items[j].Trim();

        if (!wardrobe.ContainsKey(color))
        {
            wardrobe.Add(color, new Dictionary<string, int>());
        }
        if (!wardrobe[color].ContainsKey(item))
        {
            wardrobe[color].Add(item, 0);
        }
        wardrobe[color][item]++;
        
    }

        
}
string[] find = Console.ReadLine()
    .Split(" ");

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key}clothes:");
    foreach(var item in color.Value)
    {
        Console.Write($"* {item.Key} - {item.Value}");
        if (color.Key.Trim() == find[0] && item.Key == find[1])
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}
