namespace LeetCode.Solutions;

public class ContainerWithMostWater
{
    public static void Run()
    {
        // Print(new int[] {1,8,6,2,5,4,8,3,7}, 49);
        // Print(new int[] {1,1}, 1);
        // Print(new int[] {1,3,2,5,25,24,5}, 24);
        // Print(new int[] {2,3,4,5,18,17,6}, 17);
        //Print(new int[] {4,3,2,1,4}, 9);
        Print(new int[] {76,155,15,188,180,154,84,34,187,142,22,5,27,183,111,128,50,58,2,112,179,2,100,111,115,76,134,120,118,103,31,146,58,198,134,38,104,170,25,92,112,199,49,140,135,160,20,185,171,23,98,150,177,198,61,92,26,147,164,144,51,196,42,109,194,177,100,99,99,125,143,12,76,192,152,11,152,124,197,123,147,95,73,124,45,86,168,24,34,133,120,85,81,163,146,75,92,198,126,191}, 18048);
    }

    public static void Print(int[] height, int expected)
    {
        int res = Execute(height);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] height)
    {
        /*
        int firstPointer = Array.IndexOf(height, height.Max());
        int secondP = firstPointer + 1;
        int lastPointer = Array.IndexOf(height[secondP .. ^0], height[secondP .. ^0].Max());

        // iF POINTER SECOND IS NULL ???
        
        Console.WriteLine($"first- {firstPointer}: {height[firstPointer]}. Second - {lastPointer}: {height[firstPointer+1+lastPointer]}");
        */

        if (height.Length <= 1)
            return 0;

        if (height.Length == 2)
            return GetSum(height, 0, 1);
        
        int firstPointer = 0;
        int lastPointer = height.Length - 1;
        int sum = 0;

        while (lastPointer > firstPointer)
        {
            int subSum = GetSum(height, firstPointer, lastPointer);

            sum = Math.Max(sum, subSum);

            if (height[firstPointer] <= height[lastPointer])
                firstPointer++;
            else
                lastPointer--;
            
            // if (height[firstPointer + 1] > height[firstPointer])
            //     firstPointer++;
            // else if(height[lastPointer] > height[lastPointer-1])
            //     lastPointer--;
            // else if(height[firstPointer] > height[lastPointer])
            //     lastPointer--;
            // else
            //     firstPointer++;
        }
        
        return sum;
    }

    public static int GetSum(int[] height, int first, int second) 
        => (second - first) * Math.Min(height[first], height[second]);
}