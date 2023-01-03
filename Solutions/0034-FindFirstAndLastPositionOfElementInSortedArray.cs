namespace LeetCode.Solutions;

public class FindFirstAndLastPositionOfElementInSortedArray
{
    public static void Run()
    {
        // Print(new int[] {5,7,7,8,8,10}, 8, new int[] {3,4});
        // Print(new int[] {0,0}, 0, new int[] {0,0});
        // Print(new int[] {1}, 0, new int[] {0,0});
        // Print(new int[] {1, 3}, 1, new int[] {0,0});
        // Print(new int[] {1, 3}, 1, new int[] {0,0});
        // Print(new int[] {1, 3}, 3, new int[] {1,1});
        Print(new int[] {3, 3, 3}, 3, new int[] {0,2});
    }

    public static void Print(int[] nums, int target, int[] expected)
    {
        int[] res = Execute(nums, target);
        Console.WriteLine($"current: {Helper.ConvertArrayOfDigitsToString(res)}. " +
                          $"expected: {Helper.ConvertArrayOfDigitsToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static int[] Execute(int[] nums, int target)
    {
        if (!nums.Contains(target))
            return new int[2] {-1, -1};

        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                set.Add(i);
        }

        return set.Count == 1
            ? new int[2] {set.First(), set.First()}
            : new int[2] {set.First(), set.Last()};
    }
}