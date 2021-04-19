using System;
using System.Text.RegularExpressions;

public static class Program
{
    public static string letterCount(string str)
    {
        string[] delimitedWords = str.Split(' ');
        int longest = 1;
        string longestWord ='';
        int[] countObjects = {};

        for (int i = 0; i < str.length; i++)
        {
            string word = delimitedWords[i];

            for (int j = 0; j < word.length; j++)
            {
               if (countObjects[word[j]] == countObjects[word[j]] || 0)
               {
                   countObjects[word[j]]++;
               }
            }
        }

        if longest == 1
        {
            return -1;
        }
        else
        {
            return longestWord;
        }

    }
}