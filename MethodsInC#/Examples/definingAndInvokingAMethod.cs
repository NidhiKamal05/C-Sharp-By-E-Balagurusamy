using System;
class Method  // class containing the method
{
	// Define the Cube method
	// int Cube(int x)
	internal int Cube(int x)
	{
		return (x * x * x);
	}
}
// Client class to invoke the cube method
class MethodTest
{
	public static void Main()
	{
		// Create object for invoking cube
		Method M = new Method();
		// Invoke the cube method
		int y = M.Cube(5);  // Method call
		// Write the result
		Console.WriteLine(y);
	}
}