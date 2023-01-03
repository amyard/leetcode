using System.Collections;

namespace LeetCode.Solutions;

public class ValidParentheses
{
    public static void Run()
    {
        Print("()", true);
        Print("()[]{}", true);
        Print("(]", false);
        Print("{[]}", true);
        Print("(){}}{", false);
    }

    public static void Print(string s, bool expected)
    {
        bool res = ExecuteStack(s);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool ExecuteStack(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
            return false;
        
        // last in , first out
        // pop - removes and returns an element from the top of the stack
        // peek - returns an element from the top of the stack without removing
        Stack<int> stack = new Stack<int>();

        foreach (var item in s.Select(x => ConvertParenthesesToIntNegative(x)))
        {
            if (item > 0)
            {
                stack.Push(item);
                continue;
            }

            bool tryPeek = stack.TryPeek(out int result);

            if (!tryPeek)
                return false;
            
            if (result + item == 0)
                stack.Pop();
        }
        
        return stack.Count == 0;
    }
    
    public static bool Execute(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
            return false;

        List<int> list = new List<int>(s.Length);

        foreach (var val in s.Select(t => ConvertParenthesesToIntNegative(t)))
        {
            if (list.Count == 0)
            {
                list.Add(val);
                continue;
            }
            
            if (list[^1] + val == 0 && list[^1] > 0)
            {
                list.RemoveAt(list.Count-1);
                continue;
            }

            list.Add(val);
        }
        
        return list.Count == 0;
    }

    private static int ConvertParenthesesToInt(char parentheses)
    {
        int res = parentheses switch
        {
            '{' => 1,
            '}' => 2,
            '(' => 3,
            ')' => 4,
            '[' => 5,
            ']' => 6,
            _ => 0
        };

        return res;
    }
    
    private static int ConvertParenthesesToIntNegative(char parentheses)
    {
        int res = parentheses switch
        {
            '{' => 1,
            '}' => -1,
            '(' => 2,
            ')' => -2,
            '[' => 3,
            ']' => -3,
            _ => 0
        };

        return res;
    }
}