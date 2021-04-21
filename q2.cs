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
        string[] dic = strArr[1].Split(',');
		List<string> dictionary = new List<string>();
		List<string> foundWords = new List<string>();
	
		dictionary.AddRange(dic);
		char[] characters = strArr[0].ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
			// combine string from char 0 to i
			string word = new string(characters, 0, i);
			// if combined string is in dictionary
            if (dictionary.Contains(word))
			{
				// return words
				foundWords.Add(word);
			}	
        }
		
		if (foundWords.Any())
		{
			return String.Join(", ", foundWords);
		}
		return "string not possible";
    }
}
}