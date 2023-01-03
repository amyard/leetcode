using System.Collections;

namespace LeetCode.Solutions;

public class SingleNumberTwoTwo
{
    public static void Run()
    {
        Print( new int[]{1,2,1,3,2,5}, new int[] {3,5});
        Print( new int[]{-1, 0}, new int[]{-1, 0});
        Print( new int[]{0, 1}, new int[]{0,1});
    }

    public static void Print(int[] nums, int[] expected)
    {
        int[] res = Execute(nums);
        Console.WriteLine($"current: {Helper.ConvertArrayOfDigitsToString(res)}. " +
                          $"expected: {Helper.ConvertArrayOfDigitsToString(expected)}");
        Console.WriteLine("------------------------");
    }
    
    public static int[] Execute(int[] nums)
    {
        return nums
            .GroupBy(n => n)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .ToArray();
    }
}