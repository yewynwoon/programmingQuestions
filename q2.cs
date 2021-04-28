using System;
using System.Linq;

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
		
		var foundWords = strArr[1].Split(',')
                                .Where(d => strArr[0].Contains(d))
							    .Select(d => d);
	

		if (foundWords.Count() == 2)
		{
			return String.Join(", ", foundWords);
		}
		return "string not possible";
    }
}
}