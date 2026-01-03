using System;
struct Item
{
	public string name;
	public int code;
	public double price;
}
class StructTest
{
	public static void Main()
	{
		Item fan;    // create an item
		// Assign values to members
		fan.name = "Bajaj";
		fan.code = 123;
		fan.price = 1576.50;
		// Display item details
		Console.WriteLine("Fan name: " + fan.name);
		Console.WriteLine("Fan code: " + fan.code);
		Console.WriteLine("Fan cost: " + fan.price);
	}
}