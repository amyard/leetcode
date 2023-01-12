using LeetCode.Entities;

namespace LeetCode.Solutions;
public class RotateArray
{
    public static void Run()
    {
        Print(new int[]{1,2,3,4,5,6,7}, 3, new int[] {5,6,7,1,2,3,4});
        Print(new int[]{-1,-100,3,99}, 2, new int[] {3,99,-1,-100});
    }

    public static void Print(int[] nums, int k, int[] expected)
    {
        int[] res = Execute(nums, k);
        Console.WriteLine($"current: {Helper.ConvertArrayOfDigitsToString(res)}. " +
                          $"expected: {Helper.ConvertArrayOfDigitsToString(expected)}");
        Console.WriteLine("------------------------");
    }
    
    public static int[] Execute(int[] nums, int k)
    {
        if (nums.Length < 2) 
            return nums;
            
        k %= nums.Length;

        int[] rotatePart = new int[k];

        Array.Copy(nums, nums.Length - k, rotatePart, 0, k);
        Array.Copy(nums, 0, nums, k, nums.Length - k);
        Array.Copy(rotatePart, 0, nums, 0, k);

        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums));
        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(rotatePart));

        return nums;
    }

    public static int[] Execute2(int[] nums, int k)
    {
        int startIndex = nums.Length > k
            ? nums.Length - k
            : nums.Length - (k % nums.Length);

        nums = nums[startIndex..].Concat(nums[..startIndex]).ToArray();

        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums));

        return nums;

        // List<int> result = new List<int>(nums.Length);
        // for (int i = startIndex; i < nums.Length + startIndex; i++)
        // {
        //     int iterValue = nums[(i + nums.Length) % nums.Length];
        //     result.Add(iterValue);
        // }
        //     
        // return result.ToArray();
    }
}