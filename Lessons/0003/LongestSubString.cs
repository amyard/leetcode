namespace LeetCode.Lessons._0003;

public class LongestSubString
{
    public static void Start()
    {
        var r1 = Execute("abcabcbb"); // 3 
        Print(r1, 3);
        
        // var r2 = Execute(""); // 0
        // Print(r2, 0);
        //
        // var r3 = Execute("bbbb"); // 1
        // Print(r3, 1);
        //
        // var r4 = Execute(" "); // 1
        // Print(r4, 1);
        //
        // var r5 = Execute("au"); // 2
        // Print(r5, 2);
        //
        // var r6 = Execute("dvdf");
        // Print(r6, 3);
    }

    public static void Print(int res, int expected)
    {
        Console.WriteLine($"Current - {res}. Expected: {expected}");
        Console.WriteLine("-------------------------");
    }

    public static int Execute(string s)
    {
        int res = 0;
        var span = s.AsSpan();
        
        for (int i = 0; i < s.Length; i++)
        {
            var slice = span.Slice(i + 1, s.Length - i - 1);
            var index = slice.IndexOf(span[i]);
            Console.WriteLine($"slice: {slice.ToString()}. value: {span[i]}. index: {index}.");

            if (index >=0 )
                res = index + 1 > res ? index + 1 : res;
            else
                res = slice.Length+1 > res ? slice.Length + 1 : res;
        }
        
        return res;
    }

    public static int Execute2(string s)
    {
        int res = 0;
        int lastPosition = 0;
        int temp = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var sub = s.AsSpan().Slice(lastPosition, i - lastPosition);
            if (sub.Contains(s[i]))
            {
                res = i - lastPosition > res ? i - lastPosition : res;
                lastPosition = i;
                temp = 0;
            }

            temp++;
        }
        
        return res > temp ? res : temp;
    }
}