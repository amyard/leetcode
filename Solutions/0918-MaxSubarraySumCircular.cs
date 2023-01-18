using LeetCode.Entities;

namespace LeetCode.Solutions;
public class MaxSubarraySumCircular
{
    public static void Run()
    {
        Print(new int[] {1,-2,3,-2}, 3);
        //Print(new int[] {5, -3, 5}, 10);
    }

    public static void Print(int[] nums, int expected)
    {
        int res = Execute(nums);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums)
    {
        int maxSum = int.MinValue;
        int minSum = int.MaxValue;
        int currentMax = 0;
        int currentMin = 0;
        int arraySum =0;
        
        for(int i = 0; i < nums.Length ; i++)
        {
            currentMax += nums[i];
            
            if(currentMax > maxSum) 
                maxSum = currentMax;
            
            if(currentMax <0) 
                currentMax = 0;
            
            arraySum += nums[i];
            currentMin += nums[i];
            
            if(currentMin < minSum) 
                minSum = currentMin;
            
            if(currentMin > 0) 
                currentMin = 0;
        }
        
        if(arraySum == minSum) 
            return maxSum;
        
        return Math.Max(arraySum - minSum, maxSum);
    }

    public static void GetData(int i, int[] nums)
    {
        int n = nums.Length;

        int nextIndex = (i + 1) % n;
        int prevIndex = (i - 1 + n) % n;

        int next = nums[nextIndex];
        int prev = nums[prevIndex];

        // var sum = nums[nextIndex .. prevIndex].Sum();
        
        //Console.WriteLine($"i - {i}. next - {next}. prev - {prev}.");
        Console.WriteLine($"nextIndex - {nextIndex}. prevIndex - {prevIndex}");
    }
}