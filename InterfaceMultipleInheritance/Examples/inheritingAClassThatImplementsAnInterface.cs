using System;
interface Display
{
	void Print() ;
}
class B : Display      // implements Display
{
	public void Print()
	{
		Console.WriteLine("Base Display");
	}
}
class D : B      // inherits B class
{
	public new void Print()
	{
		Console.WriteLine("Derived Display");
	}
}
class InterfaceTest3
{
	public static void Main()
	{
		D d = new D();
		d.Print();
		Display dis = (Display)d;
		dis.Print();
	}
}