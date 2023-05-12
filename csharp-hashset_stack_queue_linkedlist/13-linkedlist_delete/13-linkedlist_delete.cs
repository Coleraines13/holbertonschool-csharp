using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		try
		{
			int val = myLList.Select((item, inx) => new { item, inx }).First(el => el.inx == index).item;
			myLList.Remove(val);
		}

		catch (Exception)
		{ }
	}
}