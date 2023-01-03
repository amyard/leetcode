namespace LeetCode.Solutions;

public class SingleNumber
{
    public static void Run()
    {
        Print( new int[]{2,2,1}, 1);
        Print( new int[]{4,1,2,1,2}, 4);
        Print( new int[]{1}, 1);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var item in nums)
        {
            if (set.Contains(item))
                set.Remove(item);
            else
                set.Add(item);
        }
        
        return set.Min();
    }
}