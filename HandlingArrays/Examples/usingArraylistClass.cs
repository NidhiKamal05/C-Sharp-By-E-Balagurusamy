using System;
using System.Collections;
class City
{
	public static void Main()
	{
		ArrayList n = new ArrayList();
		n.Add("Madras");
		n.Add("Bombay");
		n.Add("Anand");
		n.Add("Calcutta");
		n.Add("Delhi");
		Console.WriteLine("Capacity = " + n.Capacity);
		Console.WriteLine("Elements present = " + n.Count);
		
		n.Sort();
		for(int i=0; i<n.Count; i++)
		{
			Console.WriteLine(n[i]);
		}
		Console.WriteLine();
		n.RemoveAt(4);
		for(int i=0; i<n.Count; i++)
		{
			Console.WriteLine(n[i]);
		}
	}
}