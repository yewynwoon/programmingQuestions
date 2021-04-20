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
	}
	
    public static string WordSplit(string[] strArr)
    {
        string[] dic = strArr[1].Split(',');
		List<string> dictionary = new List<string>();
		
		for (int i = 0; i < dic.Length; i++)
		{
			dictionary.Add(dic[i]);
		}
		
		string[] characters = strArr[0].Split();

        for (int i = 0; i < characters.Length; i++)
        {
			// combine string from char 0 to i
			string word = string.Join(characters.ToList().GetRange(0,i));
			// if combined string is in dictionary
            if (dictionary.Contains())
			{
				// return words
				return characters[0..i];
			}	
        }
		return "string not possible";
    }
}
}