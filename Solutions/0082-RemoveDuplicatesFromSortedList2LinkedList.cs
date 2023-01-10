using LeetCode.Entities;

namespace LeetCode.Solutions;

public class RemoveDuplicatesFromSortedList2LinkedList
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5))))))), 
            new ListNode(1, new ListNode(2, new ListNode(5))));
    }

    public static void Print(ListNode head, ListNode expected)
    {
        ListNode res = Execute(head);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(head)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode head)
    {
        ListNode result = new();
        ListNode iterNode = result;

        int countDuplicates = 1;

        while (head is not null)
        {
            if (head.next is not null && head.val == head.next.val)
                countDuplicates++;
            else
            {
                if (countDuplicates == 1)
                {
                    // TODO ---> write here
                    iterNode.next = head;
                    iterNode = iterNode.next;
                }

                countDuplicates = 1;
            }

            head = head.next;
        }

        return result.next;
    }
    

    public static ListNode Execute2(ListNode head)
    {
        ListNode iterData = new ListNode();
        ListNode result = iterData;

        List<int> l1 = new();

        while (head is not null)
        {
            l1.Add(head.val);
            head = head.next;
        }

        int[] resInts = l1
            .GroupBy(x => x)
            .Where(x => x.Count() == 1)
            .Select(x => x.Key)
            .ToArray();

        foreach (var item in resInts)
        {
            iterData.next = new ListNode(item);
            iterData = iterData.next;
        }

        return result;
    }
}