List<int> nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();



string command;

while ((command = Console.ReadLine()) != "end")
{
    Calculate(nums, command);
}

static void Calculate(List<int> nums, string command)
{
    if (command == "add")
    {
        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] += 1;
        }
    }
    else if (command == "multiply")
    {
        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] *= 2;
        }
    }
    else if (command == "subtract")
    {
        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] -= 1;
        }
    }
    else if (command == "print")
    {
        Console.WriteLine(string.Join(" ", nums));
    }
}