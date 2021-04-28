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
        var longestWord = str.Split(' ').OrderByDescending(w => w.
                                        GroupBy(c => c).
                                        Max(grp => grp.Count())).First();

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