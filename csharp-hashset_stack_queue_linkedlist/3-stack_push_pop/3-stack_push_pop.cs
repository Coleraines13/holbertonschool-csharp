using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		var numberOfElement = aStack.Count();
        //var topElement = aStack.Peek();

        Console.WriteLine($"Number of items: {numberOfElement}");
		
		if (aStack.Count == 0)
			Console.WriteLine("Stack is empty");
		else
			Console.WriteLine($"Top item: {aStack.Peek()}");


        bool conditionResult = aStack.Contains(search);

        Console.WriteLine($"Stack contains \"{search}\": {conditionResult}");

        while (aStack.Contains(search))
		{
			aStack.Pop();
		}
		aStack.Push(newItem);
		return aStack;
	}
}