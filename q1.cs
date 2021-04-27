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
        var longestWord = delimitedWords.OrderByDescending(w => w.
                                        GroupBy(c => c).
                                        Count()).
                                        First();

        if (longestWord != "")
        {
            return longestWord;
        }
        else
        {
            return "-1";
        }
        
        

}
}
}