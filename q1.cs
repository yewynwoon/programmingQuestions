using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
public class Program
{
    public static void Main(string[] args)
    {
        string str = "Today is the greatest day ever";
        Console.WriteLine(letterCount(str));
    }
    
    public static string letterCount(string str)
    {
        var delimitedWords = new List<string>(str.Split(' '));
        int longest = 1;
        string longestWord = " ";
        var countIEnum = delimitedWords.Select(word => word
									.GroupBy(c => c)
                            		.Max(grp => grp.Count())); 
        
		var wordTuple = new Tuple<string,int>(word, countIEnum.Max(x => x));

        if (wordTuple.Item2 > longest)
        {
            longest = wordTuple.Item2;
            longestWord = wordTuple.Item1;
        }

        if (longest == 1)
        {
            return "-1";
        }
        else
        {
            return longestWord;
        }
}
}
}