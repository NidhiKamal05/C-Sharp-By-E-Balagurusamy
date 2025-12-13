using System;
class Fibonacci {
	public static void Main() {
		Console.Write("Enter an integer, m = ") ;
		int m = int.Parse(Console.ReadLine()) ;
		int a = 0, b = 1, c = 1, i = 1 ;
		do {
			Console.Write(" " + c) ;
			c = a + b ;
			a = b ;
			b = c ;
		}
		while(++i <= m) ;
	}
}