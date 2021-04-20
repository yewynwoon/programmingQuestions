using System;
using System.Linq;

public static class Program
{
    public static string letterCount(string str)
    {
        string[] delimitedWords = str.Split(' ');
        int longest = 1;
        string longestWord ='';
        //HashSet<int> uniqueObjects = new HashSet<int>();

        for (int i = 0; i < str.length; i++)
        {
            string word = delimitedWords[i];

            for (int j = 0; j < word.length; j++)
            {
               /*if !(HashSet.Add(word[j]))
               {
                   longest++;
               }
               */
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