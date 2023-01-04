namespace LeetCode.Solutions;

public class SearchInRotatedSortedArray
{
    public static void Run()
    {
        Print(new int[]{4,5,6,7,0,1,2}, 0, 4);
        Print(new int[]{4,5,6,7,0,1,2}, 3, -1);
        Print(new int[]{1}, 0, -1);
    }

    public static void Print(int[] nums, int target, int expected)
    {
        int res = Execute(nums, target);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums, int target)
    {
        return Array.IndexOf(nums, target);
    }
}