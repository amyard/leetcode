namespace LeetCode.Solutions;

public class Sample
{
    public static void Run()
    {
        Print("42", 42);
    }

    public static void Print(string s, int expected)
    {
        int res = Execute(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string s)
    {
        return 2;
    }
}