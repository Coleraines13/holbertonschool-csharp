using System;
using System.Collections.Generic;
using System.Text;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		var newList = new List<int>();
		//char separator = ' ';
		StringBuilder output = new StringBuilder();
		for (int i = 0; i<size; i++)
        {
			newList.Add(i);
			output.Append(i);
			if (i != size - 1)
				output.Append(" ");
        }
		Console.WriteLine(output);
		return newList;
	}
}