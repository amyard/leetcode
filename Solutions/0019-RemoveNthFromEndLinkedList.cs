using LeetCode.Entities;

namespace LeetCode.Solutions;

public class RemoveNthFromEndLinkedList
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 
            2,
            new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5)))));
        
        Print(new ListNode(1), 1, new ListNode());
        
        Print(new ListNode(1, new ListNode(2)),
            1,
            new ListNode(1));
    }

    public static void Print(ListNode head, int n, ListNode expected)
    {
        ListNode res = Execute(head, n);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head, int n)
    {
        int count = 1;
        ListNode cur = head;

        //count total nodes
        while(cur.next != null)
        {
            cur = cur.next;
            count++;
        }

        //reset current pointer to head
        cur = head;

        //move current pointer to nth node
        for(int i = 0; i < count - n - 1; i++)
        {
            cur = cur.next;
        }
        
        if(count == n) 
            head = head.next;
        else 
            cur.next = cur.next.next;

        return head;
    }
    
    public static ListNode Execute2(ListNode head, int n)
    {
        int res = 0;
        ListNode result = head;

        Queue<int> queue = new();

        while (head is not null)
        {
            queue.Enqueue(head.val);
            head = head.next;
            res++;
        }

        head = result;

        // while (queue.Count != 0)
        // {
        //     if (res - n == 0)
        //     {
        //         queue.Dequeue();
        //         res--;
        //         continue;
        //     }
        //     
        //     result.next = new ListNode(queue.Dequeue());
        //     result = result.next;
        //     res--;
        // }

        for (int i = res - 1; i >= 0; i--)
        {
            if (i == n)
            {
                result.next = head.next.next;
                head = head.next.next;
                i--;
                continue;
            }

            result.next = head.next;
            head = head.next;
            var asd = "aaa";
        }

        return result.next;
    }
}