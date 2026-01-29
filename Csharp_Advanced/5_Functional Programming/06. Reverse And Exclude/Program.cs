

int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    
   
    .ToArray();

int division = int.Parse(Console.ReadLine());



for (int i = nums.Length-1; i >= 0; i--)
{
    if (nums[i] % division == 0)
    {

    }
    else
    {
        Console.Write(nums[i] + " ");
    }
}

