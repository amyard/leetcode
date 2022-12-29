namespace LeetCode.Solutions;

public class ContainsDuplicate
{
    public static void Run()
    {
        Print(new int[] {1,2,3,1}, true);
        Print(new int[] {1,2,3,4}, false);
        Print(new int[] {1,1,1,3,3,4,3,2,4,2}, true);
    }

    public static void Print(int[] nums, bool expected)
    {
        bool res = Execute2(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool Execute(int[] nums)
    {
        return nums.Distinct().Count() != nums.Length;
    }
    
    public static bool Execute2(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        return nums.Any(x => !set.Add(x));
    }
}