using System.Text;

namespace LeetCode.Solutions;

public class LongestCommonPrefix
{
    public static void Run()
    {
        Print(new string[] {"flower", "flow", "flight"}, "fl");
        Print(new string[] {"dog", "racecar", "car"}, "");
        Print(new string[] {"ds"}, "ds");
        Print(new string[] {"",""}, "");
    }

    public static void Print(string[] strs, string expected)
    {
        string res = Execute(strs);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static string Execute(string[] strs)
    {
        StringBuilder res = new ();

        if (strs.Length == 0) return res.ToString();
        if (strs.Length == 1) return strs[0];
        if (strs.Length == 1 && strs[0].Length == 0) return strs[0];
        
        for (int i = 0; i <= strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[0][i] != strs[j][i])
                    return res.ToString();
            }

            res.Append(strs[0][i]);
        }
        return res.ToString();
    }
}