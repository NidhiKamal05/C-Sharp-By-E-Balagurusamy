using System;
interface I1
{
	void Display();
}
interface I2
{
	void Display();
}
class C1 : I1, I2
{
	void I1.Display()   // no access modifier
	{
		Console.WriteLine("I1 Display");
	}
	void I2.Display()   // no access modifier
	{
		Console.WriteLine("I2 Display");
	}
}
class InterfaceTest4
{
	public static void Main()
	{
		C1 c = new C1();
		
		I1 i1 = (I1)c;
		i1.Display();
		
		I2 i2 = (I2)c;
		i2.Display();
	}
}