namespace LeetCode.Solutions;

public class RemoveDuplicatesFromSortedArray2
{
    public static void Run()
    {
        Print(new int[] {1,1,1,2,2,3}, 5);
        Print(new int[] {0,0,1,1,1,1,2,3,3}, 7);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        int leftPointer = 1;
        int currValAppears = 0;

        for (int n = 1; n < nums.Length; n++)
        {
            // only twice appears
            // different values
            if (nums[n] == nums[n-1] && currValAppears == 0)
            {
                nums[leftPointer] = nums[n];
                currValAppears++;
                leftPointer++;
            }
            else if (nums[n] != nums[n - 1])
            {
                nums[leftPointer] = nums[n];
                currValAppears = 0;
                leftPointer++;
            }
            
            //Console.WriteLine($"{n} - {nums[n]}");
        }

        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums));
        
        return leftPointer;
    }
}