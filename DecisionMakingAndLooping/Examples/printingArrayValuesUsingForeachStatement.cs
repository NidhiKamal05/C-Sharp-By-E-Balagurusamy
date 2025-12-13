using System;
class ForeachTest
{
	public static void Main()
	{
		int[] arrayInt = {11, 22, 33, 44};
		foreach(int m in arrayInt)
		{
			Console.Write(" " + m);
		}
		Console.WriteLine();
	}
}