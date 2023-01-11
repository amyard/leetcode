using LeetCode.Entities;

namespace LeetCode.Solutions;

public class ReverseLinkedListEasy
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
            new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1))))));
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
        if (head is null)
            return head;
        
        // REVERSE ITERATION
        ListNode myReverse = new ListNode(head.val);
        head = head.next;

        while (head is not null)
        {
            ListNode tempNode = new ListNode(head.val, myReverse);
            myReverse = tempNode;
            head = head.next;
        }
        
        return myReverse;
    }
    
    public static ListNode Execute2(ListNode head)
    {
        ListNode result = new();
        ListNode iterNode = result;
        Stack<int> stack = new();

        while (head is not null)
        {
            stack.Push(head.val);
            head = head.next;
        }

        while (stack.Count != 0)
        {
            iterNode.next = new ListNode(stack.Pop());
            iterNode = iterNode.next;
        }

        return result.next;
    }
}