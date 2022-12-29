namespace LeetCode.Lessons._0009;

public class PalindromeNumber
{
    public static void Run()
    {
        // bool res1 = Execute(121);
        // Print(res1, true);
        //
        // bool res2 = Execute(-121);
        // Print(res2, false);
        //
        // bool res3 = Execute(10);
        // Print(res3, false);
        //
        Execute(12321);
    }

    public static bool Execute(int n)
    {
        int sum = 0;
        var temp = n;   
        
        while(n > 0)      
        {
            int r = n % 10;      
            sum = (sum * 10) + r;      
            n = n / 10;      
            //Console.WriteLine($"n: {n}. r: {r}. sum: {sum}.");
        }
        
        return temp == sum;
    }

    public static void Print(bool current, bool expected)
    {
        Console.WriteLine($"Current - {current}. Expected: {expected}");
        Console.WriteLine("-------------------------");
    }
}