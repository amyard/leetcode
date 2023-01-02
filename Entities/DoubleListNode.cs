namespace LeetCode.Entities;

public class DoubleListNode
{
    public int val;
    public DoubleListNode next;
    public DoubleListNode prev;

    public DoubleListNode(int val=0, DoubleListNode next=null, DoubleListNode prev=null) 
    {
        this.val = val;
        this.next = next;
        this.prev = prev;
        next.prev = this;
    }
}


// new ListNode2(
//     1, 
//     new ListNode2( 
//             2,
//             new ListNode2()
//     ), 
//     null);