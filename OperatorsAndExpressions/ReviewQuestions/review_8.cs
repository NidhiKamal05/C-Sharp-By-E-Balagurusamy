using System;
class LogicalExpressions
{
	public static void Main()
	{
		int a = 5, b = 10, c = -6;
		bool bool1 = a > b && a < c;
		bool bool2 = a < b && a > c;
		bool bool3 = a < b || b > a;
		bool bool4 = b > 15 && c < 0 || a > 0;
		bool bool5 = (a/2.0 == 0.0 && b/2.0 != 0.0) || c < 0.0;
		Console.WriteLine(" a > b && a < c = " +  bool1);
		Console.WriteLine(" a < b && a > c = " + bool2);
		Console.WriteLine(" a < b || b > a = " + bool3);
		Console.WriteLine(" b > 15 && c < 0 || a > 0 = " + bool4);
		Console.WriteLine(" (a/2.0 == 0.0 && b/2.0 != 0.0) || c < 0.0 = " + bool5);
	}
}