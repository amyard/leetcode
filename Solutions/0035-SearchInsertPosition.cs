using System.Collections;

namespace LeetCode.Solutions;

public class SearchInsertPosition
{
    public static void Run()
    {
        Print(new int[] {1,3,5,6}, 5,2);
        Print(new int[] {1,3,5,6}, 2,1);
        Print(new int[] {1,3,5,6}, 7,4);
    }

    public static void Print(int[] nums, int target, int expected)
    {
        int res = Execute(nums, target);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums, int target)
    {
        int res = Array.IndexOf(nums, target);

        if (res < 0)
        {
            //Hashtable hashtable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                    return i;
            }

            return nums.Length;
        }
        
        return res;
    }
}