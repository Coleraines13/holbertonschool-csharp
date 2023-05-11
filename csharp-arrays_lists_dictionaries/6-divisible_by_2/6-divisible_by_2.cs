using System;
using System.Collections.Generic;
class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		var boolList = new List<bool>();
		foreach(int number in myList)
        {
			boolList.Add(number % 2 == 0);
        }
		return boolList;
	}
}