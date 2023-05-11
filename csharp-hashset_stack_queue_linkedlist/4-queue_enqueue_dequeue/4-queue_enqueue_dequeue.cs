using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		var numberOfElement = aQueue.Count();
		

		Console.WriteLine($"Number of items: {numberOfElement}");

		if (aQueue.Count == 0)
			Console.WriteLine("Queue is empty");
		else
			Console.WriteLine($"First item: {aQueue.Peek()}");
		
		aQueue.Enqueue(newItem);

		bool conditionResult = aQueue.Contains(search);

		Console.WriteLine($"Queue contains \"{search}\": {conditionResult}");

		
		while (aQueue.Contains(search))
		{
			aQueue.Dequeue();
		}
		
		return aQueue;
	}
}