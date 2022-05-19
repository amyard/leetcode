namespace LeetCode.Lessons._0003;

public class LongestSubString
{
    public static void Start()
    {
        var r1 = Execute("abcabcbb"); // 3 
        Print(r1, 3);
        
        var r2 = Execute(""); // 0
        Print(r2, 0);
        
        var r3 = Execute("bbbb"); // 1
        Print(r3, 1);
        
        var r4 = Execute(" "); // 1
        Print(r4, 1);
        
        var r5 = Execute("au"); // 2
        Print(r5, 2);
        
        var r6 = Execute("dvdf");
        Print(r6, 3);
        
        var r7 = Execute("pwwkew");
        Print(r7, 3);
    }

    public static void Print(int res, int expected)
    {
        Console.WriteLine($"Current - {res}. Expected: {expected}");
        Console.WriteLine("-------------------------");
    }

    public static int Execute(string s)
    {
        int res = 0;
        int start = 0;
        int end = 0;
        var span = s.AsSpan();

        for (int i = 0; i < span.Length; i++)
        {
            if (span.Slice(start, end).Contains(span[i]))
            {
                var index = span.Slice(start, end).IndexOf(s[i]);
                start += index + 1;
                end -= index;
            }
            else
            {
                end++;
            }

            res = Math.Max(res, span.Slice(start, end).Length);
        }

        return res;
    }

    public static int NotMySolution(string s)
    {
        int longestLength = 0;
        //this will have the start index of current substring
        int start = 0;
        //this will hold current longest substring with out repeation
        List<char> characters = new List<char>();
        //we will loop through all characters that we have
        for (var i = 0; i < s.Length; i++)
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("iterate  " + s[i]);
            //if there is a character repeated 
            if (characters.Contains(s[i]))
            {
                //now just stop current one and start new from the next character of the repeating characters
                var repeatedCharacterIndex = characters.FindIndex(x => x == s[i]);
                Console.WriteLine(repeatedCharacterIndex + " " + s[i]);
                //new start will be - +1 because we want to take next character of repeating character
                start = start + repeatedCharacterIndex + 1;
                Console.WriteLine(start);
                //we will be removing the characters before repeating character and the repeating character 
                //so that we dont need to loop through them again 
                characters = characters.Skip(repeatedCharacterIndex + 1).ToList();
                //add current character to the substring
                characters.Add(s[i]);
            }
            else
            {
                //if its not repeating character then add it to the substring
                Console.WriteLine("added  " + s[i]);
                characters.Add(s[i]);
            }

            Console.WriteLine("characters: " + string.Join("", characters));
            longestLength = Math.Max(longestLength, characters.Count);
        }
        return longestLength;
    }
    
    public static int Execute3(string s)
    {
        int res = 0;
        var span = s.AsSpan();
        
        for (int i = 0; i < s.Length; i++)
        {
            var slice = span.Slice(i + 1, s.Length - i - 1);
            var index = slice.IndexOf(span[i]);
        
            if (index >=0 )
                res = index + 1 > res ? index + 1 : res;
            else
                res = slice.Length+1 > res ? slice.Length + 1 : res;
            
            Console.WriteLine($"slice: {slice.ToString()}. value: {span[i]}. index: {index}. res - {res}.");
        }
        
        return res;
    }

    public static int Execute2(string s)
    {
        int res = 0;
        int lastPosition = 0;
        int temp = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var sub = s.AsSpan().Slice(lastPosition, i - lastPosition);
            if (sub.Contains(s[i]))
            {
                res = i - lastPosition > res ? i - lastPosition : res;
                lastPosition = i;
                temp = 0;
            }

            temp++;
        }
        
        return res > temp ? res : temp;
    }
}