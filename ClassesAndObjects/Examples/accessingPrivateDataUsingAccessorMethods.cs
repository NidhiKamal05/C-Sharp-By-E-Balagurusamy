using System;
class Number
{
	private int number;
	public void SetNumber( int x )         	// accessor method
	{
		number = x;							// private number accessible
	}
	public int GetNumber()					// accessor method
	{
		return number;
	}
}

class NumberTest
{
	public static void Main ()
	{
		Number n = new Number();
		n.SetNumber(100);		// set value
		Console.WriteLine("Number = " + n.GetNumber()); // get value
		// n.number; // Error! Cannot access private data
	}
}