namespace LeetCode.Solutions;

public class RemoveDuplicatesFromSortedArray
{
    public static void Run()
    {
        //Print(new int[] {1,1,2}, 2);
        Print(new int[] {0,0,1,1,1,2,2,3,3,4}, 5);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        int left = 1;
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i] != nums[i-1])
            {
                nums[left] = nums[i];
                left++;
            }            
        }
        
        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums));
        
        return left;
    }
    
    public static int Execute2(int[] nums)
    {
        if (nums.Length < 2)
            return nums.Length;
        
        int res = 1;
        int LastIntPointer = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == LastIntPointer)
            {
                nums[i] = int.MaxValue;
                continue;
            }

            LastIntPointer = nums[i];
            res++;
        }
        
        Array.Sort(nums);

        Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums));

        return res;
    }
}