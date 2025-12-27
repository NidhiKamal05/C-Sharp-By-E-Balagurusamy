using System;
class SortReverse
{
	public static void Main()
	{
		// creating an array
		int[] x = {30, 10, 80, 90, 20};
		Console.WriteLine("Array before sorting");
		foreach(int i in x)
			Console.Write(" " + i);
		Console.WriteLine();
		// Sorting and reversing the array elements
		Array.Sort(x);
		Array.Reverse(x);
		Console.WriteLine("Array after Sorting and Reversing");
		foreach(int i in x)
			Console.Write(" " + i);
		Console.WriteLine();
	}
}