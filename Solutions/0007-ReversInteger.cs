namespace LeetCode.Lessons._0007;

public class ReversInteger
{
    public static void Run()
    {
        Print(12345);
        Print(-12345);
    }

    public static void Print(int x)
    {
        int res = Execute(x);
        Console.WriteLine($"current: {x}. reversed: {res}");
        Console.WriteLine("------------");
    }

    public static int Execute(int x)
    {
        long reverseRes = 0;

        while (x != 0)
        {
            int r = x % 10;      
            reverseRes = (reverseRes * 10) + r;      
            x = x / 10;      
            //Console.WriteLine($"n: {x}. r: {r}. sum: {reverseRes}.");
        }
        
        
        return reverseRes > Int32.MaxValue || reverseRes < Int32.MinValue ? 0 : (int)reverseRes;
    }
}