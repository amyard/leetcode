namespace LeetCode;

public static class Helper
{
    public static string ConvertArrayOfDigitsToString(int[] digits) => string.Join(", ", digits);
    public static string ConvertArrayOfDigitsToString(List<int> digits) => string.Join(", ", digits);
}