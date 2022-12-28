namespace LeetCode.Solutions;

public class RemoveElement
{
    public static void Run()
    {
        // Print(new int[] {3,2,2,3}, 3, 2);
        // Print(new int[] {0,1,2,2,3,0,4,2}, 2, 5);
        Print(new int[] {0,1,2,2,5,2,3,0,4,2}, 2, 6);
    }

    public static void Print(int[] s, int removeElement, int expected)
    {
        int res = Execute(s, removeElement);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(int[] nums, int val)
    {
        //Console.WriteLine(string.Join(",", nums.Select(x => x)));
        
        if (nums.Length == 0) 
            return 0;

        if (nums.Length == 1)
            return nums[0] != val ? 1 : 0;
        
        // Not My
        // int a = 0;
        // for(int i=0; i<nums.Length; i++){
        //     Console.WriteLine($"iteration - {i}");
        //     if(nums[i] != val){
        //         nums[a]= nums[i];
        //         a++;
        //         Console.WriteLine("done");
        //     }
        //
        //     var asd = string.Join(",", nums.Select(x => x));
        //     Console.WriteLine($"{asd}{Environment.NewLine}-------------------------------------");
        // }
        
        // My Solution
        int a = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = Int32.MaxValue;
                continue;
            }

            a++;
        }
        
        Array.Sort(nums);
        
        return a;
    }
}