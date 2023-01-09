namespace LeetCode.Solutions;

public class MaxSubArray
{
    public static void Run()
    {
        Print(new int[] {-2,1,-3,4,-1,2,1,-5,4}, 6);
        Print(new int[] {5,4,-1,7,8}, 23);
        Print(new int[] {1}, 1);
        Print(new int[] {-2,-1}, -1);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int sum = 0;
        int maxSum = nums[0];

        for (int i=0; i<nums.Length; i++) {
            sum += nums[i];
            if (nums[i] > sum) 
                sum = nums[i];
            
            if (sum > maxSum) 
                maxSum = sum;
        }  
        
        return maxSum;
    }
    
    public static int Execute2(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int maxSum = 0;
        int sum = nums[0];

        // Not worked correct
        // for (int i = 1; i < nums.Length; i++)
        // {
        //     if (sum + nums[i] > 0)
        //         sum += nums[i];
        //     else if (nums[i] > 0)
        //         sum = nums[i];
        //     else
        //         sum = 0;
        //
        //     maxSum = sum > maxSum ? sum : maxSum;
        // }
        
        for (int i = 1; i < nums.Length; i++) {
            int n = nums[i];
            
            //previous sum is negative
            if (n > n + sum) 
            { 
                //so accumulated sum is this element itself
                sum = n; 
                
                //and make it a new max, if true
                if (sum > maxSum) 
                    maxSum = sum; 
            } 
            //previous sum is positive and 
            else if (n + sum > maxSum) 
            { 
                //together with current element exceeds prev. max
                sum += n; 
                
                //then we have a new max
                maxSum = sum; 
            } 
            else 
            {
                //sum is positive but max remains intact
                sum += n; 
            }
        }
        
        return maxSum;
    }
}