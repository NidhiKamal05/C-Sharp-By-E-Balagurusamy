using System ;

class Sum {
	public static void Main() {
		double a = 5.5, b = 6.7 ;
		double ans = a + b ;
		// Console.WriteLine($"{a} + {b} = {ans}") ;
		// Console.WriteLine($"{a:F1} + {b:F1} = {ans:F1}") ;
		Console.WriteLine("{0} + {1} = {2}", a, b, ans) ;
	}
}