using LeetCode.Entities;

namespace LeetCode.Solutions;
public class JumpGame
{
    public static void Run()
    {
        // Print(new int[]{2,3,1,1,4}, true);
        // Print(new int[]{3,2,1,0,4}, false);
        Print(new int[]{2,0,0}, true);
    }

    public static void Print(int[] nums, bool expected)
    {
        bool res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool Execute(int[] nums)
    {
        int power = 0;

        for (int i = 0; i < nums.Length; i++) {
            power --;
            power = Math.Max(power, nums[i]);

            if (power == 0 && i != nums.Length - 1)
                return false;
        }
        return true;
    }
}