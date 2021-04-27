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
        var dictionary = strArr[1].Split(',')
						.ToList();

		
		var foundWords = dictionary.Where(d => strArr[0].Contains(d))
							 .Select(d => d)
							 .ToList();
		
		
		if (foundWords.Count() = 2)
		{
			return String.Join(", ", foundWords);
		}
		return "string not possible";
    }
}
}