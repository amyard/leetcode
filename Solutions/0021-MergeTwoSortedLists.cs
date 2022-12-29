namespace LeetCode.Solutions;

public class MergeTwoSortedLists
{
    public static void Run()
    {
        Print(new List<int>() {1,2,3},new List<int>() {1,2,3}, new List<int>() {1,2,3},);
    }

    public static void Print(ListNode list1, ListNode list2, ListNode expected)
    {
        ListNode res = Execute(list1, list2);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static ListNode Execute(ListNode list1, ListNode list2)
    {
        return list1;
    }
}


public class ListNode 
{
    public int val;
    public ListNode next;
    
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}
 