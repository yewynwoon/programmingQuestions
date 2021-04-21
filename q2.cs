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
		int count = 0;
	
		dictionary.AddRange(dic);
		char[] characters = strArr[0].ToCharArray();
		List<char> charactersList = characters.OfType<char>().ToList();

        while (charactersList.Any())
        {
			// combine string from char 0 to i
			string word = new string(charactersList.ToArray(), 0, count + 1);
			// if combined string is in dictionary
			Console.WriteLine(word);
			count++;
            if (dictionary.Contains(word))
			{
				// add found word to list
				foundWords.Add(word);
				// delete found word from list
				charactersList.RemoveRange(0,count);
				count = 0;
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