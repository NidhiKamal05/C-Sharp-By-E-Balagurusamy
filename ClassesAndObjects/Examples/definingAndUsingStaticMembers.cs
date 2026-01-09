using System;
class MathOperation
{
	public static float mul(float x, float y)
	{
		return x*y ;
	}
	public static float divide(float x, float y)
	{
		return x/y ;
	}
}
class MathApplication
{
	public static void Main()
	{
		float a = MathOperation.mul(4.0F,5.0F);
		float b = MathOperation.divide(a,2.0F);
		Console.WriteLine("b = " + b);
	}
}