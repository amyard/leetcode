using LeetCode.Entities;

namespace LeetCode.Solutions;

public class MergeTwoSortedLists
{
    public static void Run()
    {
        Print(new ListNode(1, new ListNode(2, new ListNode(4, null))),
            
            new ListNode(1, new ListNode(3, new ListNode(4, null))),
            
            new ListNode(1, 
                new ListNode(1, 
                    new ListNode(2, 
                        new ListNode(3, 
                            new ListNode(4,
                                new ListNode(4, null)))))));
    }

    public static void Print(ListNode list1, ListNode list2, ListNode expected)
    {
        ListNode res = Execute(list1, list2);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();
        ListNode current = result;

        while (list1 is not null && list2 is not null) {
            if (list1.val < list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 ?? list2;
        
        return result.next;

    }
}