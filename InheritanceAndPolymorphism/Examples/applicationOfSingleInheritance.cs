using System;
class Room             // base class
{
	public int length;
	public int breadth;
	public Room(int x, int y)    // base constructor
	{
		length = x;
		breadth = y;
	}
	public int Area()
	{
		return (length * breadth);
	}
}
class BedRoom : Room    // Inheriting Room
{
	int height;
	public BedRoom(int x, int y, int z) : base(x,y)      // subclass constructor
	{
		height = z;
	}
	public int Volume()
	{
		return (length * breadth * height);
	}
}
class InherTest
{
	public static void Main()
	{
		BedRoom room1 = new BedRoom (14, 12, 10);
		int area1 = room1.Area();        // superclass method
		int volume1 = room1.Volume();    // subclass method
		Console.WriteLine("Area1 = " + area1);
		Console.WriteLine("Volume1 = " + volume1);
	}
}