using System;
class StaticMethod
{
	public static void Main()
	{
		double y = Square(2.5F);        // Method call
		Console.WriteLine(y);
	}
	static double Square(float x)       // Method definition
	{
		return (x * x);
	}
}