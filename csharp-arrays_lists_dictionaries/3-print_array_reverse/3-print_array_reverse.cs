using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null || array.Length == 0)
        {
			Console.WriteLine();
			return;
        }
		
		char separator = ' ';
		for (int i = array.Length -1; i >= 0; i--)
        {
			if (i == 0)
				separator = '\n';
			Console.Write($"{array[i]}{separator}");
        }
	}
}