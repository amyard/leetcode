using System.Collections;

namespace LeetCode.Solutions;

public class ValidAnagram
{
    public static void Run()
    {
        Print("anagram", "nagaram", true);
        Print("rat", "car", false);
    }

    public static void Print(string s, string t, bool expected)
    {
        bool res = Execute(s, t);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool Execute(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        return string.Join("", s.OrderBy(x => x)) == string.Join("", t.OrderBy(x => x));
    }
}