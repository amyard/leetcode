using LeetCode.Entities;

namespace LeetCode.Solutions;

public class DeleteDuplicatesFromLinkedList
{
    public static void Run()
    {
        // Print(new ListNode(1, new ListNode(1, new ListNode(2))), 
        //     "1, 2");
        //
        Print(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))),
            "1,2,3");
    }

    public static void Print(ListNode head, string expected)
    {
        ListNode res = Execute(head);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head)
    {
        if(head == null) return head;
        
        ListNode current = head;
        
        while(current.next != null)
        {
            if(current.val == current.next.val)
                current.next = current.next.next;
            else
                current = current.next;
        }
        
        return head;
    }
    
    public static ListNode ExecuteNotWork(ListNode head)
    {
        if(head == null) return head;
        
        ListNode result = new ListNode();
        ListNode current = result;

        while (head is not null)
        {
            if (current.val != head.val)
            {
                current.next = head;
                current = current.next;
            }

            head = head.next;
        }
        
        // First value will be 0
        return result.next;
    }
}