using System;
class Item
{
	public void Company()               // base class
	{
		Console.WriteLine("Item Code = XXX");
	}
}

class Fan : Item                               // derived class
{
	public void Model()
	{
		Console.WriteLine("Fan Model : Classic");
	}
}

class SimpleInheritance
{
	public static void Main()
	{
		Item item = new Item();
		Fan fan = new Fan();
		item.Company();
		fan.Company();
		fan.Model();
	}
}