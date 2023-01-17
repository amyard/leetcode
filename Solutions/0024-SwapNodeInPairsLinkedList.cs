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
        ListNode slow = head;
        ListNode fast = head;
        
        while(slow != null && slow.next != null)
        {
            fast = slow.next;
            
            //swap the nodes
            (fast.val,slow.val) = (slow.val,fast.val);
            // fast.val = slow.val;
            // slow.val = fast.val;
                
            //move on
            slow = fast.next;

            var asd = "aaaa";
        }
        return head;
    }
}