using System;

class Debugging1
{
	public static void Main()
	{
		// for(int m = 1; m < 100; m){
			// Console.WriteLine(m, m * m);
			// if(m = 10) break;
		// }
		for(int m = 1; m < 100; ++m){
			Console.WriteLine(m);
			Console.WriteLine(m * m);
			if(m == 10) break;
		}
	}
}