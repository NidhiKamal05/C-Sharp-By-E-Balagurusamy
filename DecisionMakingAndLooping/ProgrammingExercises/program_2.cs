using System;
class FactorialTable {
	public static void Main() {
		Console.Write("Enter an integer, num = ") ;
		int num = int.Parse(Console.ReadLine()) ;
		int fact = 1 ;
		for(int i=1; i<=num; ++i) {			
			fact *= i ;
			// Console.WriteLine("{0}! = {1}", i, fact) ;
			Console.WriteLine(i + "! = " + fact) ;
		}
	}
}