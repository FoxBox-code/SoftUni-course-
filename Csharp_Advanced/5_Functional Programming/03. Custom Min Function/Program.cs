Func<int[], int> findSmallest = numbers =>
{
    int smallest = int.MaxValue;

    foreach (var number in numbers)
    {
        if (number < smallest)
        {
            smallest = number;
        }
    }
    return smallest;
};


int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine(findSmallest(nums));