using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		HashSet<int> toAdd = new HashSet<int>();
		int sum = 0;
		foreach (int number in myList)
			toAdd.Add(number);
		foreach (int elem in toAdd)
			sum += elem;
		return sum;
	}
}