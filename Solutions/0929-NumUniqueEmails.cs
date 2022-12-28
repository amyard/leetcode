using System.Collections;

namespace LeetCode.Solutions;

public class NumUniqueEmails
{
    public static void Run()
    {
        Print(new string[] {"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"}, 2);
        Print(new string[] {"a@leetcode.com","b@leetcode.com","c@leetcode.com"}, 3);
    }

    public static void Print(string[] emails, int expected)
    {
        int res = Execute(emails);
        Console.WriteLine($"current: {res}. expected: {expected}");
        Console.WriteLine("------------------------");
    }

    public static int Execute(string[] emails)
    {
        var hashtable = new Hashtable();

        foreach (var email in emails)
        {
            var splitArray = email.Split("@");
            var localName = splitArray[0].Replace(".", "").Split("+")[0];
            splitArray[0] = localName;

            var asd = string.Join("@", splitArray);

            if(!hashtable.ContainsValue(asd))
                hashtable.Add(Array.IndexOf(emails, email), asd);
            
        }

        var res = hashtable.Count;
        
        return res;
    }
}