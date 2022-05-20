using System.Numerics;

namespace LeetCode.Lessons._0008;

public class StringToInt
{
    public static void Run()
    {
        Print("42", 42);
        Print("     -42", -42);
        Print("456 with words", 456);
        //Print("lol 456 with words", 456);
        Print("words and 987", 0);
        Print("+1", 1);
        Print("+-12", 0);
        Print("21474836460", 2147483647);
        Print("9223372036854775808", 2147483647);
        Print("-91283472332", -2147483648);
    }

    public static void Print(string s, int expected)
    {
        int res = Execute(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string s)
    {
        var span = s.Trim().AsSpan();
        long res = 0;
        int negative = 1; 

        for (int i = 0; i < span.Length; i++)
        {
            if (!Char.IsDigit(span[i]))
            {
                if ((span[i] == '-' || span[i] == '+') && i == 0)
                    continue;
                break;
            }
            
            res = span[i]-'0' == 0 && res == 0 ? res : res * 10 + span[i]-'0';

            if (i > 0 && span[i - 1] == '-')
            {
                negative = -1;
            }
            
            if (res*negative < Int32.MinValue)
                return Int32.MinValue;
            
            if (res*negative > Int32.MaxValue)
                return Int32.MaxValue;
        }

        res *= negative;

        return (int)res;
    }
    
    public static int Execute2(string s)
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