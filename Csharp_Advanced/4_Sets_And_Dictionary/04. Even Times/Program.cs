Dictionary<int , int> nums = new Dictionary<int , int>();


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int given = int.Parse(Console.ReadLine());

    if (!nums.ContainsKey(given))
    {
        nums.Add(given, 0);
    }
    nums[given]++;

}

//


Console.WriteLine(nums.Single(x=>x.Value %2==0).Key); // to use single we must bake sure that there is only one elment that matches the given description.