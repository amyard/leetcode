namespace LeetCode.Solutions;

public class PascalsTriangle2
{
    public static void Run()
    {
        Print(8, new List<int>() {1,3,3,1});
    }

    public static void Print(int s, List<int> expected)
    {
        var res = Execute(s);
        Console.WriteLine($"current: {Helper.ConvertArrayOfDigitsToString(res.ToList())}. " +
                          $"expected: {Helper.ConvertArrayOfDigitsToString(expected)}");
        Console.WriteLine("------------------------");
    }

    public static IList<int> Execute(int rowIndex)
    {
        if (rowIndex == 0) 
            return new List<int>(rowIndex) {1};
        
        List<IList<int>> main = new();
        
        for (var i = 0; i < Enumerable.Range(0, rowIndex+1).ToList().Count; i++)
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

        return main[^1];
    }

    public static IList<int> ExecuteFactorialReverse(int rowIndex)
    {
        if (rowIndex == 0) 
            return new List<int>(rowIndex) {1};
        
        List<int> inner = new(1);
        inner.Add(1);
            
        for (int k = 1; k < rowIndex; k++)
        {
            inner.Add(Fact(8) / (Fact(8-k) * Fact(k)));
            // Console.WriteLine(sub);
        }
            
        inner.Add(1);
            
        //Console.WriteLine(string.Join(",", inner));

        return inner;
    }

    private static int Fact(int n) => n == 0 ? 1 : n * Fact(n - 1);
}