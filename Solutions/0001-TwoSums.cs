using System.Collections;

namespace LeetCode.Lessons._0001;

public static class TwoSums
{
    public static void Start()
    {
        //var res = Execute(new int[] {2,7,11,15}, 9);
        var res = Execute(new int[] {3,2,4}, 6);
        Console.WriteLine($"{res[0]} - {res[1]}");
    }

    public static int[] Execute(int[] nums, int target)
    {
        var hashTable = new Hashtable(); 

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashTable.ContainsKey(target - nums[i]))
                return new[] {(int)hashTable[target - nums[i]], i};

            hashTable[nums[i]] = i;
        }
        return new[] {-1, -1};
    }
}