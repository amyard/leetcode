using LeetCode.Entities;

namespace LeetCode.Solutions;
public class SwapNodeInPairsLinkedList
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))),
            new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(4)))));
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
        ListNode result = new ListNode();
        ListNode result2 = result;
        result = head;
        
        int iter = 1;

        if (head.next is null)
            return head;

        while (head is not null)
        {
            if (iter % 2 == 0)
            {
                head = head.next;
                iter++;
                continue;
            }

            result.next = head;
            result = head.next;
            
            head = head.next;
            iter++;
        }

        return result;
    }
}