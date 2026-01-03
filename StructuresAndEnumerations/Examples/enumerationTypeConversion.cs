using System;
class Enumtype
{
	enum Direction
	{
		North ,
		East = 10 ,
		West ,
		South
	}
	public static void Main()
	{
		Direction d1 = 0;                 // implicit conversion
		Direction d2 = Direction.East;
		Direction d3 = Direction.West;
		Direction d4 = (Direction)12;     // explicit conversion
		
		Console.WriteLine("d1 = " + d1);
		Console.WriteLine("d2 = " + (int)d2);
		Console.WriteLine("d3 = " + d3);
		Console.WriteLine("d4 = " + d4);
		
		// Console.WriteLine() ;
		
		// Console.WriteLine("d1 = " + (int)d1);
		// Console.WriteLine("d2 = " + d2);
		// Console.WriteLine("d3 = " + (int)d3);
		// Console.WriteLine("d4 = " + (int)d4);
	}
}