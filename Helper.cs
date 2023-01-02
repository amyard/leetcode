using System.Text;
using LeetCode.Entities;

namespace LeetCode;

public static class Helper
{
    public static string ConvertArrayOfDigitsToString(int[] digits) => string.Join(", ", digits);
    public static string ConvertArrayOfDigitsToString(List<int> digits) => string.Join(", ", digits);
    
    public static string ConvertLinkedListToString(ListNode node)
    {
        StringBuilder sb = new();

        while (node is not null)
        {
            sb.Append($"{node.val} ");
            node = node.next;
        }
        
        return sb.ToString();
    }
}