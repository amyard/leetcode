namespace LeetCode.Solutions;

public class Sqrt
{
    public static void Run()
    {
        //Print(4, 2);
        Print(8, 2);
        Print(16, 4);
        Print(35, 5);
        Print(127, 11);
    }

    public static void Print(int s, int expected)
    {
        int res = Execute(s);
        int res2 = ExecuteStolen(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine($"current: {res2}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    // BINARY SEARCH
    public static int Execute(int s)
    {
        long start = 0;
        long end = s;

        while (start + 1 < end)
        {
            long medium = start + (end - start) / 2;

            if (medium * medium == s)
                return (int) medium;
            else if (medium * medium < s)
                start = medium;
            else
                end = medium;
        }

        if (end * end == s)
            return (int) end;

        return (int) start;
    }
    
    public static int ExecuteStolen(int x)
    {
        if (x <= 1) return 1;
        
        long high = x;

        while (high > x / high)
        {
            high = (int) ((high + x / high) / 2);
            var asd = "aaaa";
        }

        return (int) high;
    }
    
    public static int Execute2(int s) => (int) Math.Floor(Math.Sqrt(s));
}