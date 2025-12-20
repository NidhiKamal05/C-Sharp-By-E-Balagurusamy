using System;
class Output
{
	static void Square(int x, out int y)
	{
		y = x * x;
	}
	public static void Main()
	{
		int m;    // need not be initialized
		Square(10, out m);
		Console.WriteLine("m = " + m);
	}
}