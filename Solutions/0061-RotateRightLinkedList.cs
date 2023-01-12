using LeetCode.Entities;

namespace LeetCode.Solutions;

public class RotateRightLinkedList
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 
            2,
            new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(2, new ListNode(3))))));
        
        Print(new ListNode(0, new ListNode(1, new ListNode(2))),
            4,
            new ListNode(2, new ListNode(0, new ListNode(1))));
    }

    public static void Print(ListNode head, int k, ListNode expected)
    {
        ListNode res = Execute(head, k);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head, int k)
    {
        List<int> list = new();
        ListNode result = head;

        if(head is null)
            return result;

        while (head is not null)
        {
            list.Add(head.val);
            head = head.next;
        }

        int startIndex = list.Count > k
            ? list.Count - k
            : list.Count - (k % list.Count);

        head = result;
        
        for (int i = startIndex; i < list.Count() + startIndex; i++)
        {
            int iterValue = list[(i + list.Count()) % list.Count()];

            head.next = new ListNode(iterValue);
            head = head.next;
        }

        return result.next;
    }
}