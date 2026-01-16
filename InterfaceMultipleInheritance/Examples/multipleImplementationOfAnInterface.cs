using System;
interface Area
{
	double Compute(double x);
}
class Square : Area
{
	public double Compute(double x)
	{
		return (x * x) ;
	}
}
class Circle : Area
{
	public double Compute(double x)
	{
		return (Math.PI * x * x);
	}
}
class InterfaceTest2
{
	public static void Main()
	{
		Square sqr = new Square() ;
		Circle cir = new Circle() ;
		Area area;
		area = sqr as Area;      //casting
		Console.WriteLine("Area of Square = " + area.Compute(10.0));
		area = cir as Area;      //casting
		Console.WriteLine("Area of Circle = " + area.Compute(10.0));
	}
}