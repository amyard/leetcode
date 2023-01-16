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
        ListNode res = SortList(head);

        return res;
    }
    
    public static ListNode SortList(ListNode head) {
        if (head == null || head.next == null)
            return head; //already sorted.
        
        //Divide this list in 2 parts at the half point. 
        //"head" will be truncated at the half point and will be the start of the first half
        //"start2" will be the second half of the list
        ListNode start2 = DivideLinkedList(head);
        
        //sort both halves recursively
        head = SortList(head);
        start2 = SortList(start2);
        
        //Merge the two sorted lists by changing the reference pointers to achieve O(1) space
        ListNode root = MergeLinkedListOpt(head, start2);
        
        return root;
    }
    
    private static ListNode DivideLinkedList(ListNode head)
    {
        //use a fast and slow pointer to find midpoint of link list
        ListNode slow = head;
        ListNode fast = head.next;
        ListNode start2 = null;
        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            head = head?.next;
            fast = fast.next?.next;
        }
        
        start2 = slow.next;
        head.next = null;
        return start2;
    }
    
    
    private static ListNode MergeLinkedListOpt(ListNode start1, ListNode start2)
    {
        //initial new node as root
        ListNode prev = new ListNode(0);
        ListNode head = prev;
        
        while (start1 != null && start2 != null)
        {
            if (start1.val < start2.val)
            {
                prev.next = start1;
                start1 = start1.next;
            }
            else
            {
                prev.next = start2;
                start2 = start2.next;
            }
            prev = prev.next;
        }
        
        //if one list is empty and the other has values, attach to the tail of answer
        if (start1 == null && start2 != null)
        {
            prev.next = start2;
        }
        if (start2 == null && start1 != null)
        {
            prev.next = start1;
        }
        return head.next;
    }
    
    public static ListNode Execute2(ListNode head)
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