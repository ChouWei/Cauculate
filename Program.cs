﻿// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 2, 17, 7, 15 };
        var result = TwoSum(arr, 9);
        Console.WriteLine($"Two sum of 9 is {arr[result[0]]} and {arr[result[1]]}. Indexes are {result[0]} and {result[1]}");

        // Test Redundant Select
        List<int> lst = Enumerable.Range(1, 10).ToList();

        foreach (int i in lst.Where(e => e % 2 == 0))
        {
            Console.WriteLine($"Array index of redundant select: {i}");
        }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                return new int[] { dict[target - nums[i]], i };
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        return new int[] { };
    }
}
