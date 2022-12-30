using System.Text;

namespace LeetCode.Solutions;

public class AddBinary
{
    public static void Run()
    {
        Print("11", "1", "100");
        Print("1010", "1011", "10101");
        // Print("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", 
        //     "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011", 
        //     "10101");
    }

    public static void Print(string a, string b, string expected)
    {
        string res = Execute(a, b);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static string Execute(string a, string b)
    {
        return Convert.ToString(Convert.ToInt64(a, 2) + Convert.ToInt64(b, 2), 2);
    }
    
    public static string ExecuteStolen(string a, string b)
    {
        Stack<char> stack = new();
        int n = Math.Max(a.Length, b.Length);

        int carry = 0;
        for (int index = 0; index < n; index++)
        {
            int option = 0;
            option += a.Length > index ? a[^(index + 1)] - '0' : 0;
            option += b.Length > index ? b[^(index + 1)] - '0' : 0;
            option += carry;

            char digit = (char)('0' + option % 2);
            carry = option / 2;

            stack.Push(digit);
        }

        if (carry == 1) stack.Push('1');

        return new string(stack.ToArray());

    }
}