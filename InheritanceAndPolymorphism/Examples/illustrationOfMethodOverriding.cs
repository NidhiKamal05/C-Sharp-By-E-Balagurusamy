using System;
class Super                         //base class
{
	protected int x ;
	public Super (int x)
	{
		this.x = x ;
	}
	public virtual void Display () // method defined with virtual
	{
		Console.WriteLine("Super x = " + x);
	}
}
class Sub : Super             // derived class
{
	int y;
	public Sub (int x, int y) : base (x)
	{
		this.y = y;
	}
	public override void Display ()     // method defined again with override
	{
		Console.WriteLine("Super x = " + x);
		Console.WriteLine("Sub y = " + y);
	}
}
class OverrideTest
{
	public static void Main()
	{
		Sub s1 = new Sub (100, 200);
		s1.Display () ;
	}
}