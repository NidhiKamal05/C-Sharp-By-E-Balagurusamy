using System;
class Scope
{
	public static void Main()
	{
		int m=100;
		for(int i=0; i<=4; i++)
		{
			// int m=200; // Error
			Console.WriteLine(m*i); // ok m = 100
		}
	}
}