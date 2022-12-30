namespace LeetCode.Solutions;

public class MaxProfit
{
    public static void Run()
    {
        Print(new int[] {7,1,5,3,6,4}, 5);
        Print(new int[] {7,1,6,3,6,4}, 5);
        Print(new int[] {7,6,4,3,1}, 0);
        Print(new int[] {1, 2}, 1);
        Print(new int[] {2,4,1}, 2);
    }

    public static void Print(int[] prices, int expected)
    {
        int res = Execute(prices);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] prices)
    {
        if (prices.Length < 2) return 0;

        int end = prices[^1];
        int max = 0;

        for (int i = prices.Length - 2; i >= 0; i--)
        {
            if (end - prices[i] > max)
                max = end - prices[i];

            if (prices[i] > end)
                end = prices[i];
        }
        
        return max;
    }
    
    public static int ExecuteNotWorked(int[] prices)
    {
        if (prices.Length < 2) return 0;

        int min = prices[0];
        int max = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (min > prices[i])
                min = prices[i];
            else if (max < prices[i])
                max = prices[i];

            var asd = "aaaa";
        }
        
        
        return max - min > 0 ? max - min : 0;
    }
}