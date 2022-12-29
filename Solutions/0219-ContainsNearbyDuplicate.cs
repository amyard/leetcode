namespace LeetCode.Solutions;

public class ContainsNearbyDuplicate
{
    public static void Run()
    {
        Print(new int[] {1,2,3,1}, 3, true);
        Print(new int[] {1,0,1,1}, 1, true);
        Print(new int[] {1,2,3,1,2,3}, 2, false);
    }

    public static void Print(int[] nums, int k, bool expected)
    {
        bool res = Execute2(nums, k);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    // Slowly
    public static bool Execute(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                    return true;
            }
        }
        
        return false;
    }
    
    // Fast
    public static bool Execute2(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(dict.TryGetValue(nums[i], out var ind) && Math.Abs(ind - i) <= k)
                return true;

            dict[nums[i]] = i;
        }
        
        return false;
    }
}