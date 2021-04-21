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
        List<string> delimitedWords = new List<string>(str.Split(' '));
        int longest = 1;
        string longestWord = " ";

        for (int i = 0; i < delimitedWords.Count; i++)
        {
            string word = delimitedWords[i];
			Console.WriteLine(word);

            var characters = word.GroupBy(w => w)
                            .Where(grp => grp.Count() > 1)
                            .Select(grp => grp.Key);
                
            if (characters.Count() > longest)
            {
                longest = characters.Count();
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