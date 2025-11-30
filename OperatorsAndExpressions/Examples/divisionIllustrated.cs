using System;
class DivisionExample
{
	static void Main()
	{
		int firstInt, secondInt;
		float firstFloat, secondFloat;
		double firstDouble, secondDouble;
		decimal firstDecimal, secondDecimal;
		firstInt = 12;
		secondInt = 5;
		firstFloat = 12;
		secondFloat = 5;
		firstDouble = 12.55;
		secondDouble = 5;
		firstDecimal = 12;
		secondDecimal = 5;
		Console.WriteLine("--Division Operator usage in Different Types of Numeric Data--");
		Console.WriteLine("\nInteger Division: {0}", firstInt / secondInt);
		Console.WriteLine("Float Division: {0}", firstFloat / secondFloat);
		Console.WriteLine("Double Division: {0}", firstDouble / secondDouble);
		Console.WriteLine("Decimal Division: {0}", firstDecimal / secondDecimal);
		Console.WriteLine("\n--Modulo Division Operator usage in Different Types of Numeric Data--");
		Console.WriteLine("\nInteger Modulo Division: {0}", firstInt % secondInt);
		Console.WriteLine("Float Modulo Division: {0}", firstFloat % secondFloat);
		Console.WriteLine("Double Modulo Division: {0}", firstDouble % secondDouble);
		Console.WriteLine("Decimal Modulo Division: {0}", firstDecimal % secondDecimal);
	}
}