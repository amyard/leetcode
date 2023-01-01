namespace LeetCode.Solutions;

public class PascalsTriangle
{
    public static void Run()
    {
        Print(10, 6);
    }

    public static void Print(int s, int expected)
    {
        var res = Execute(s);
        //Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static IList<IList<int>> Execute(int numRows)
    {
        List<IList<int>> main = new();
        
        for (var i = 0; i < Enumerable.Range(0, numRows).ToList().Count; i++)
        {
            if (i == 0)
            {
                main.Add(new List<int>(){1});
                Console.WriteLine(1);
                continue;
            }

            List<int> inner = new(i+1);
            inner.Add(1);
            
            for (int sub = 1; sub < main[i-1].Count; sub++)
            {
                inner.Add(main[i-1][sub-1] + main[i-1][sub]);
                // Console.WriteLine(sub);
            }
            
            inner.Add(1);
            main.Add(inner);
            
            Console.WriteLine(string.Join(",", main[i]));
        }

        return main;
    }
}