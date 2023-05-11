using System;
using System.Collections.Generic;
class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int landmark = int.MinValue;
		string keyOfMaxValue = "None";
		foreach (KeyValuePair < string, int>pair in myList)
        {
			if(pair.Value > landmark)
            {
				landmark = pair.Value;
				keyOfMaxValue = pair.Key;
			}
        }
		return keyOfMaxValue;

	}
}