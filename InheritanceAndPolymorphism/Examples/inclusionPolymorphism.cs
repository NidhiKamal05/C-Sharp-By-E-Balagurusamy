using System;
class Maruthi
{
	public virtual void Display() // virtual method
	{
		Console.WriteLine("Maruthi car");
	}
}
class Esteem : Maruthi
{
	public override void Display()
	{
		Console.WriteLine("Maruthi Esteem");
	}
}
class Zen : Maruthi
{
	public override void Display()
	{
		Console.WriteLine("Maruthi Zen");
	}
}
class Inclusion
{
	public static void Main()
	{
		Maruthi m = new Maruthi();
		m = new Esteem();    // upcasting
		m.Display();
		m = new Zen();       // upcasting
		m.Display();
	}
}