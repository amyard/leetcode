﻿namespace LeetCode.Solutions;

public static class e_0013_RomanToInt
{
    public static void Run()
    {
        // Print("III", 3);
        // Print("LVIII", 58);
        Print("MCMXCIV", 1994);
    }

    public static void Print(string s, int expected)
    {
        int res = Execute(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string s)
    {
        int res = 0;
        int length = s.Length;
        
        if (length == 0) return res;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"prev - {res}");
            if (i + 1 != length && s[i + 1] == 'V' && s[i] == 'I')
            {
                res += 4;
                i++;
            }
            else if (i + 1 != length && s[i + 1] == 'X' && s[i] == 'I')
            {
                res += 9;
                i++;
            }
            else if (s[i] == 'I')
                res += 1;
            else if (s[i] == 'V')
                res += 5;
            else if (i + 1 != length && s[i + 1] == 'L' && s[i] == 'X')
            {
                res += 40;
                i++;
            }
            else if (i + 1 != length && s[i + 1] == 'C' && s[i] == 'X')
            {
                res += 90;
                i++;
            }
            else if (s[i] == 'X')
                res += 10;
            else if (s[i] == 'L')
                res += 50;
            else if (i + 1 != length && s[i + 1] == 'D' && s[i] == 'C')
            {
                res += 400;
                i++;
            }
            else if (i + 1 != length && s[i + 1] == 'M' && s[i] == 'C')
            {
                res += 900;
                i++;
            }
            else if (s[i] == 'C')
                res += 100;
            else if (s[i] == 'D')
                res += 500;
            else if (s[i] == 'M')
                res += 1000;

            // Console.WriteLine($"after - {res}");
            // Console.WriteLine($"iter - {s[i]}");
            // Console.WriteLine("-----------------");
        }
        
        return res;
    }
}