using System ;

class BoxingAndUnboxing
{
	public static void Main()
	{
		int m = 100 ;
		
		/*BOXING*/
		// object om = m ; // creates a box to hold m
		object om = (object)m ; // C-style casting
		m = 20 ;
		Console.WriteLine(m) ; // m = 20
		Console.WriteLine(om) ; // om = 100
		
		/*UNBOXING*/
		int n = (int)om ;
		Console.WriteLine(n) ; // n = 100
	}
}