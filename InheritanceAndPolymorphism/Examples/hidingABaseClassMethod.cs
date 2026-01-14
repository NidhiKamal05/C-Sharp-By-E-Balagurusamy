using System;
class Base
{
	public void Display()
	{
		Console.WriteLine("Base Method");
	}
}

class Derived : Base
{
	public new void Display()            // hides base method
	{
		Console.WriteLine("Derived Method");
	}
}

class HideTest
{
	public static void Main()
	{
		Derived d = new Derived();
		d.Display ();
	}
}