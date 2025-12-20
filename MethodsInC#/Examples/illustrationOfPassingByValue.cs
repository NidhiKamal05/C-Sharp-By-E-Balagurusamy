using System;
class PassByValue
{
	static void Change(int m)
	{
		m = m + 10;   // value of m is changed
	}
	public static void Main()
	{
		int x = 100;
		Change(x);
		Console.WriteLine("x = " + x);
	}
}