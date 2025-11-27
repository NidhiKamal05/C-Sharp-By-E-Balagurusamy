using System;
class IdentifierExample
{
	public static void Main()
	{
		// Using if keyword as an identifier by prefixing @
		int @if;
		Console.WriteLine("--Demonstrating use of if keyword as an identifier by pefixing @--\n");
		for(@if = 0; @if < 10; @if++)
			Console.WriteLine("The value of @if is: {0}", @if);
	}
}