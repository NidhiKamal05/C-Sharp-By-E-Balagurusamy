using System;
class Rectangle
{
	public int length, width;
	public Rectangle(int x, int y) // Defining constructor
	{
		length = x;
		width = y;
	}
	public int RectArea()
	{
		return (length * width);
	}
}
class RectangleArea
{
	public static void Main()
	{
		Rectangle rect1 = new Rectangle(15,10); // Calling constructor
		int area1 = rect1.RectArea();
		Console.WriteLine("Area1 = " + area1);
	}
}