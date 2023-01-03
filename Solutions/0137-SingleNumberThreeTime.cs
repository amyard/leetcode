using System.Collections;

namespace LeetCode.Solutions;

public class SingleNumberThreeTime
{
    public static void Run()
    {
        Print( new int[]{2,2,3,2}, 3);
        Print( new int[]{0,1,0,1,0,1,99}, 99);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (var item in nums)
        {
            if (dict.ContainsKey(item))
                dict[item] += 1;
            else
                dict[item] = 1;
        }

        return dict.FirstOrDefault(x => x.Value == 1).Key;
    }

    public static int Execute2(int[] nums)
    {
        return nums
            .GroupBy(n => n)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .Single();
    }
}