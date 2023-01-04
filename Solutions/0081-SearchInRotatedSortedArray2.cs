namespace LeetCode.Solutions;

public class SearchInRotatedSortedArray2
{
    public static void Run()
    {
        Print(new int[]{4,5,6,7,0,1,2}, 0, true);
        Print(new int[]{4,5,6,7,0,1,2}, 3, false);
        Print(new int[]{1}, 0, false);
        Print(new int[]{2,2,2,3,2,2,2}, 3, true);
    }

    public static void Print(int[] nums, int target, bool expected)
    {
        bool res = Execute(nums, target);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool Execute(int[] nums, int target)
    {
        if (nums.Length == 0)
            return false;

        if (nums.Length == 1)
            return nums[0] == target;
        
        int left = 0;
        int right = nums.Length - 1;

        while (right+1 > left)
        {
            if (nums[left] == target || nums[right] == target)
                return true;

            left++;
            right--;
        }

        return false;
    }
}