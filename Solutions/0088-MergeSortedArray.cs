namespace LeetCode.Solutions;

public class MergeSortedArray
{
    public static void Run()
    {
        Print(new int[] {1,2,3,0,0,0}, 3, new int[] {2,5,6}, 3, new int[]{1,2,2,3,5,6});
        Print(new int[] {1}, 1, new int[] {}, 0, new int[]{1});
        Print(new int[] {0}, 0, new int[] {1}, 1, new int[]{1});
    }

    public static void Print(int[] nums1, int m, int[] nums2, int n, int[] expected)
    { 
        int[] res = Execute(nums1, m, nums2, n);
        Console.WriteLine($"current: {Helper.ConvertArrayOfDigitsToString(nums1)}. expected: {Helper.ConvertArrayOfDigitsToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static int[] Execute(int[] nums1, int m, int[] nums2, int n)
    {
        if(m+n < nums1.Length)
            Array.Resize(ref nums1, n+m);
        
        Array.Sort(nums1);
        Array.Sort(nums2);

        // Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums1));
        // Console.WriteLine(Helper.ConvertArrayOfDigitsToString(nums2));
        
        int secondArrayIteratorStart = 0;
        
        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] == 0)
            {
                for (int j = secondArrayIteratorStart; j < nums2.Length; j++)
                {
                    if (nums2[j] != 0)
                    {
                        nums1[i] = nums2[j];
                        secondArrayIteratorStart = j + 1;
                        break;
                    }
                }
            }
        }
        
        Array.Sort(nums1);
        
        return nums1;
    }
}