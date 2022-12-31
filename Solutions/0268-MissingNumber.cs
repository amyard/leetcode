namespace LeetCode.Solutions;

public class MissingNumber
{
    public static void Run()
    {
        Print(new int[] {3,0,1}, 2);
        Print(new int[] {0,1}, 2);
        Print(new int[] {9,6,4,2,3,5,7,0,1}, 8);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = ExecuteStolen(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        int max = nums.Length;
        if (max != nums.Max()) return max;
        
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums[i])
                return i;
        }
        
        return 0;
    }

    public static int ExecuteStolen(int[] nums)
    {
        return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    }
}