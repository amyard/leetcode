using LeetCode.Entities;

namespace LeetCode.Solutions;

public class ReverseLinkedList
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 
           2,4,
           new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5))))));
        
        Print(new ListNode(1),
            1,1,
            new ListNode(1));
    }

    public static void Print(ListNode head, int left, int right, ListNode expected)
    {
        ListNode res = Execute(head, left, right);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head, int left, int right)
    {
        ListNode result = new ListNode();
        ListNode iterNode = result;
        
        Stack<int> stack = new Stack<int>();
        int counter = 1;

        while (head is not null)
        {
            if (counter >= left && counter <= right)
            {
                stack.Push(head.val);
                
                if (counter == right)
                {
                    while (stack.Count() != 0)
                    {
                        // TODO --> insert data
                        iterNode.next = new ListNode(stack.Pop());
                        iterNode = iterNode.next;
                    }
                }
            }
            else
            {
                // TODO --> iterate correct
                iterNode.next = head;
                iterNode = iterNode.next;
            }

            counter++;
            head = head.next;
        }

        return result.next;
    }
}