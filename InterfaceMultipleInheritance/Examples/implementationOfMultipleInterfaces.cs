using System ;
interface Addition
{
	int Add() ;
}
interface Multiplication
{
	int Mul() ;
}
class Computation : Addition, Multiplication
{
	int x, y ;
	public Computation(int x, int y)            // Constructor
	{
		this.x = x ;
		this.y = y ;
	}
	public int Add()                            // Implement Add()
	{
		return (x + y) ;
	}
	public int Mul()                            // Implement Mul()
	{
		return (x * y) ;
	}
}
class InterfaceTest1
{
	public static void Main()
	{
		Computation com = new Computation(10, 20);
		// Console.WriteLine("   Sum = " + com.Add());
		// Console.WriteLine("   Product = " + com.Mul());
		Addition add = (Addition)com;                    // casting
		Console.WriteLine("Sum = " + add.Add());
		Multiplication mul = (Multiplication)com;        // casting
		Console.WriteLine("Product = " + mul.Mul());
	}
}