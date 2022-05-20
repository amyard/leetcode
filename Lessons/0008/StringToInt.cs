namespace LeetCode.Lessons._0008;

public class StringToInt
{
    public static void Run()
    {
        Print("42", 42);
        Print("     -42", -42);
        Print("456 with words", 456);
        Print("lol 456 with words", 456);
        // Print("", 0000);
        // Print("", 0000);
    }

    public static void Print(string s, int expected)
    {
        int res = Execute(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string s)
    {
        var span = s.AsSpan();
        long res = 0;
        int negative = 1; 

        for (int i = 0; i < span.Length; i++)
        {
            if (Char.IsDigit(span[i]) && span[i]-'0' > 0)
            {
                res = res * 10 + span[i]-'0';
             
                if (i > 0 && span[i - 1] == '-')
                    negative = -1;
            }
        }

        res *= negative;

        if (res > Int32.MaxValue)
            return Int32.MaxValue;
        
        if (res < Int32.MinValue)
            return Int32.MinValue;

        return (int)res;
    }
}