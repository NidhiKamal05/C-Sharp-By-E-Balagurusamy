using System;
class Params
{
	static void Parray(params int[] arr)
	{
		Console.Write("Array elements are:");
		foreach(int i in arr)
			Console.Write(" " + i);
		Console.WriteLine();
	}
	public static void Main()
	{
		int[] x = {11, 22, 33};
		Parray(x);       // call 1
		Parray();             // call 2
		Parray(100, 200);          // call 3
		
		Oarray(10, 20, "abc");
	}
	
	static void Oarray(params object[] x)
	{
		foreach(object i in x) {
			Console.Write(" " + i);
		}
	}
}