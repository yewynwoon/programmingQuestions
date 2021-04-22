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
		
		foreach (var word in delimitedWords)
		{
			var mostRepeated = word.GroupBy(w => w)
                            .Max(grp => grp.Count());
                
            if (mostRepeated > longest)
            {
                longest = mostRepeated;
                longestWord = word;
            }
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