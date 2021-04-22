using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
public static class Program
{
	public static void Main(string[] arg)
	{
		string[] strArr = {"hellocat", "apple,bat,cat,goodbye,hello,yellow,why"};
		Console.WriteLine(WordSplit(strArr));
	}
	
    public static string WordSplit(string[] strArr)
    {
		var foundWords = new List<string>();
        var dictionary = strArr[1].Split(',').
						ToList();

		foreach (var word in dictionary.Where(d => strArr[0].Contains(d)))
		{
			foundWords.Add(word);
		}
		
		
		if (foundWords.Any())
		{
			return String.Join(", ", foundWords);
		}
		return "string not possible";
    }
}
}