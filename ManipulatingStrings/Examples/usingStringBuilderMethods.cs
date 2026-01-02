using System.Text;   // For using StringBuilder
using System;
class StringBuilderMethod
{
	public static void Main()
	{
		StringBuilder s = new StringBuilder("Object ");
		Console.WriteLine("Original string     : " + s);
		Console.WriteLine("Length              : " + s.Length);
		// Appending a string
		s.Append("language ");
		Console.WriteLine("String now          : " + s);
		// Inserting a string
		s.Insert(7, "oriented ");
		Console.WriteLine("Modified string     : " + s);
		// Setting a character
		int n = s.Length;
		s[n-1] = '!';
		Console.WriteLine("Final string        : " + s);
	}
}