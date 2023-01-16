using LeetCode.Entities;

namespace LeetCode.Solutions;
public class SortLinkedList
{
    public static void Run()
    {
        Print(new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3)))), 
            new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
    }

    public static void Print(ListNode head, ListNode expected)
    {
        ListNode res = Execute(head);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head)
    {
        ListNode result = new ();
        List<int> set = new ();
        head = result;

        while (head is not null)
        {
            set.Add(head.val);
            head = head.next;
        }

        set.Sort();
        foreach (var item in set)
        {
            result.next = new ListNode(item);
            result = result.next;
        }
        
        return head.next;
    }
}