using System;
class Strings
{
	public static void Main()
	{
		string[]countries = {"India", "Germany", "America", "France"};
		int n = countries.Length;
		// Sort alphabetically
		Array.Sort(countries);
		for(int i = 0; i < n; i++) {
			Console.WriteLine(countries[i]);
		}
		Console.WriteLine();
		// Reverse the array elements
		Array.Reverse(countries);
		for(int i = 0; i < n; i++)
		{
			Console.WriteLine(countries[i]);
		}
	}
}