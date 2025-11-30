using System;

class ConversionExample
{
	public static void Main()
	{
		int iInt = 22;
		long lLongInt = 44;
		double dDouble = 1.406;
		lLongInt = iInt;
		dDouble = iInt;
		// iInt = lLongInt;
		// lLongInt = dDouble;
	}
}