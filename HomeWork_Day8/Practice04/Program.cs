int[] nums = { 1, 1, 1, 2, 2, 3, 3, 3, 3 };
int maxCount = 0;
int mostFrequent = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    int count = 0;
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            count++;
        }
    }

    if (count > maxCount)
    {
        maxCount = count;
        mostFrequent = nums[i];
    }
}

Console.WriteLine("Most frequent number: " + mostFrequent);