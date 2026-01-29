Dictionary<string , int> keyValuePairs = new Dictionary<string , int>();


keyValuePairs.Add("king", 7);


Console.WriteLine(keyValuePairs["king"]);
foreach (var item in keyValuePairs)
{
    Console.WriteLine(item.Key);
}
