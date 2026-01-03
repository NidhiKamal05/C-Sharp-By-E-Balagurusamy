using System;
class Area
{
	public enum Shape
	{
		Circle,
		Square
	}
	public void AreaShape( int x, Shape shape)
	{
		double area;
		switch(shape)
		{
			case Shape.Circle:
				area = Math.PI * x * x;
				Console.WriteLine("Circle area = " + area);
				break;
			case Shape.Square:
				area = x * x;
				Console.WriteLine("Sqaure Area = " + area);
				break;
			default:
				Console.WriteLine("Invalid Input");
				break;
		}
	}
}

class EnumTest
{
	public static void Main()
	{
		Area area = new Area();
		area.AreaShape( 15, Area.Shape.Circle);
		area.AreaShape( 15, Area.Shape.Square);
		area.AreaShape( 15, (Area.Shape) 1 );
		area.AreaShape( 15, (Area.Shape) 10 );
	}
}