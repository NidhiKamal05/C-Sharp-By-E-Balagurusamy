using System;
struct Rectangle
{
	int a, b;
	public Rectangle ( int x, int y )  // constructor
	{
		a = x;
		b = y;
	}
	public int Area()                  // a method
	{
		return ( a * b );
	}
	public void Display()              // another method
	{
		Console.WriteLine("Area = " + Area()) ;
	}
}
class TestRectangle
{
	public static void Main()
	{
		Rectangle rect =  new Rectangle( 10, 20 );
		rect.Display();    // invoking Display() method
	}
}