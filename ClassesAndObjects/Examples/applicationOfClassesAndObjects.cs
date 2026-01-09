using System;
class Rectangle
{
	public int length, width;               // Declaration of variables
	
	public void GetData(int x, int y)       // Declaration of method
	{
		length = x;
		width = y;
	}
	
	public int RectArea()       			// Definition of another method
	{
		int area = length * width;
		return (area);
	}
}

class RectArea
{											// class with main method
	public static void Main()
	{
		int area1, area2;  					// Local variables
		Rectangle rect1 = new Rectangle();  // Creating objects
		Rectangle rect2 = new Rectangle();
		
		rect1.length = 15;					// Accessing variables
		rect1.width  = 10;
		area1 = rect1.length * rect1.width;
		
		rect2.GetData(20,12);				// Accessing methods
		area2 = rect2.RectArea();
		
		Console.WriteLine("Area1 = " + area1);
		Console.WriteLine("Area2 = " + area2);
	}
}