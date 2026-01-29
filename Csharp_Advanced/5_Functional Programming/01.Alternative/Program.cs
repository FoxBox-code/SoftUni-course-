string[] strings = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printNames = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));


printNames(strings);
