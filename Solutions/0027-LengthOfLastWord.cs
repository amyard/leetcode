namespace LeetCode.Solutions;

public class LengthOfLastWord
{
    public static void Run()
    {
        Print("Hello World", 5);
        Print("   fly me   to   the moon  ", 4);
        Print("luffy is still joyboy", 6);
    }

    public static void Print(string s, int expected)
    {
        int res = Execute(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        return s.Split(" ", StringSplitOptions.RemoveEmptyEntries)[^1].Length;
    }
}