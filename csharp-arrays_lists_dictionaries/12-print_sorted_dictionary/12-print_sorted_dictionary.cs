using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		var sortedDict = myDict.OrderBy(x => x.Key);
		foreach(KeyValuePair<string, string>pair in sortedDict)
        {
			Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
		
	}
}