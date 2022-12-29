namespace LeetCode.Solutions;

public class PlusOne
{
    public static void Run()
    {
        Print(new int[] {1,2,3}, new int[] {1,2,4});
        Print(new int[] {4,3,2,1}, new int[] {4,3,2,2});
        Print(new int[] {9}, new int[] {1,0});
        // Print(new int[] {9,9}, new int[] {1,0,0});
    }

    public static void Print(int[] digits, int[] expected)
    {
        int[] res = Execute(digits);
        Console.WriteLine($"current: {ConvertToString(res)}. expected: {ConvertToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static int[] Execute(int[] digits)
    {
        int lastIndexValue = digits[^1] + 1;
        List<int> lastArray = lastIndexValue
            .ToString()
            .Select(x => int.Parse(x.ToString()))
            .ToList();
        
        Array.Resize(ref digits, digits.Length - 1);
        
        var asd2 = digits.Concat(lastArray).ToArray();
        
        return asd2;
    }

    private static string ConvertToString(int[] digits) => string.Join(", ", digits);
}