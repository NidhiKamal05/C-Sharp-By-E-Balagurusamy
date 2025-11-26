using System;
class SampleEight
{
	public static void Main()
	{
		Console.Write("Enter your name: ");
		string name = Console.ReadLine();
		Console.WriteLine("Hello " + name);
		
		Console.Write("What is your name? ");
		string s;
		s = Console.ReadLine();
		Console.WriteLine("Hello " + s);
		Console.Write("What is your name? ");		
		s = Console.ReadLine();
		Console.WriteLine("You look nice at " + s);
	}
}