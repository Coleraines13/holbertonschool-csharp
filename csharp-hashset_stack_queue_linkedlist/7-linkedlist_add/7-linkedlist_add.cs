using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> myFirstNode = new LinkedListNode<int>(n);
		myLList.AddFirst(myFirstNode);
		return myFirstNode;
	}
}