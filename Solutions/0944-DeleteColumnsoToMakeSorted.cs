namespace LeetCode.Solutions;

public class DeleteColumnsToMakeSorted
{
    public static void Run()
    {
        Print(new string[]{"cba","daf","ghi"}, 1);
        Print(new string[]{"a","b"}, 0);
        Print(new string[]{"zyx","wvu","tsr"}, 3);
        Print(new string[]{"rrjk","furt","guzm"}, 2);
    }

    public static void Print(string[] strs, int expected)
    {
        int res = Execute(strs);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string[] strs)
    {
        int res = strs[0].Length;

        for (int i = 0; i < strs[0].Length; i++)
        {
            var col = strs.Select(s => s[i]);
            if (col.OrderBy(c => c).SequenceEqual(col)) 
                res--;
        }

        return res;
    }
    
    public static int Execute2(string[] strs)
    {
        int res = 0;
        
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                // int curr = ConvertStringToAlphabeticInt(strs[j][i]);
                // int prev = ConvertStringToAlphabeticInt(strs[j - 1][i]);
                
                if (strs[j][i] < strs[j - 1][i])
                {
                    res++;
                    break;
                }
            }
        }
        
        return res;
    }

    private static int ConvertStringToAlphabeticInt(char c) => (int) c % 32;
}