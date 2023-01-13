using LeetCode.Entities;

namespace LeetCode.Solutions;
public class DivideTwoIntegers
{
    public static void Run()
    {
        // Print(10, 3, 3);
        // Print(7, -3, -2);
        // Print(-7, -3, 2);
        // Print(-1, 1, -1);
        // Print(1, 1, 1);
        Print(-2147483648, -1, 2147483647);
    }

    public static void Print(int dividend, int divisor, int expected)
    {
        int res = Execute(dividend, divisor);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int dividend, int divisor)
    {
        nint d1 = dividend;
        if(d1/divisor >= 2147483647) return 2147483647;
        return (dividend/divisor);
        
        // if(dividend >= Int32.MaxValue)
        //     dividend = Int32.MaxValue;
        //
        // if(dividend <= Int32.MinValue)
        //     dividend = Int32.MinValue+1;
        //
        // int baseVal = divisor;
        // int iterator = 0;
        //
        // while (Math.Abs(dividend)+1 > Math.Abs(divisor))
        // {
        //     divisor += baseVal;
        //     iterator++;
        // }
        //
        // int negativeValue = (divisor < 0 && dividend > 0) || (dividend < 0 && divisor > 0) ? -1 : 1;
        //
        // return iterator * negativeValue;
    }
}