using System;
using System.Linq;

public static class Program
{
    public static string letterCount(string str)
    {
        string[] delimitedWords = str.Split(' ');
        int longest = 1;
        string longestWord ='';

        for (int i = 0; i < str.length; i++)
        {
            string word = delimitedWords[i];

            var characters = word.GroupBy(x => x).Where(y => y.Count() > 1).Select(z=>z.Key);

            characters.ForEach(item=>
            {
                int counter = 0;
                if (item.Count() > 1)
                {
                    counter++;

                    if (counter > longest)
                    {
                        longest = counter;
                        longestWord = word;
                    }
                }
            });

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