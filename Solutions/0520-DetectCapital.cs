namespace LeetCode.Solutions;

public class DetectCapital
{
    public static void Run()
    {
        // Print("USA", true);
        // Print("leetcode", true);
        // Print("Google", true);
        Print("FlaG", false);
    }

    public static void Print(string word, bool expected)
    {
        bool res = Execute(word);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static bool Execute(string word)
    {
        Console.WriteLine(FirstCharToUpperStringCreate(word));
        return word.ToUpper() == word || word.ToLower() == word || FirstCharToUpperStringCreate(word) == word;  
        //return 2;
    }
    
    public static string FirstCharToUpperStringCreate(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }
        
        return string.Create(input.Length, input.ToLower(), static (Span<char> chars, string str) =>
        {
            chars[0] = char.ToUpperInvariant(str[0]);
            str.AsSpan(1).CopyTo(chars[1..]);
        });
    }
}