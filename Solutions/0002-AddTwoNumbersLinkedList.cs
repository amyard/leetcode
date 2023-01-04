using System.Text;
using LeetCode.Entities;

namespace LeetCode.Solutions;

public class AddTwoNumbersLinkedList
{
    public static void Run()
    {
        Print(new ListNode(2, new ListNode(4, new ListNode(3))),
            new ListNode(5, new ListNode(6, new ListNode(4))),
            new ListNode(7, new ListNode(0, new ListNode(8)))
            );
        
        Print(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))),
            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))),
            new ListNode(7, new ListNode(0, new ListNode(8)))
        );
    }

    public static void Print(ListNode l1, ListNode l2, ListNode expected)
    {
        ListNode res = Execute(l1,l2);
        Console.WriteLine($"current: {Helper.ConvertLinkedListToString(res)}. " +
                          $"expected: {Helper.ConvertLinkedListToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode curr = dummyHead;
        
        int sum = 0;
        int carry = 0;
        
        //carry!=0 for the last node
        while(l1 != null || l2 != null || carry != 0) 
        {
            sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            carry = sum / 10;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        
        //we don't want to return head as it will add a node=0 at the start 
        return dummyHead.next;
    }
}