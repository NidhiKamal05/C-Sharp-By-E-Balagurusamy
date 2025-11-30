using System;

class Program {
	public static void Main() {
		int x = 5, y = 4 ;
		Console.WriteLine("x = " + x) ;
		Console.WriteLine("y = " + y) ;
		// z = x - y = 100 ;                 // INVALID
		int z = x - (y = 100) ;
		Console.WriteLine("x = " + x) ;
		Console.WriteLine("y = " + y) ;
		Console.WriteLine("z = " + z) ;
	}
}