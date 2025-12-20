using System ;
class Calc {
	internal void Product(ref int a, ref int b, ref int c) {
		c = a * b ;
	}
	public static void Main() {
		Calc c = new Calc() ;
		int x = 100 ;
		int y = 295 ;	
		int z = 0 ;
		
		c.Product(ref x, ref y, ref z) ;
		
		Console.WriteLine();
		Console.WriteLine(x + " * " + y + " = " + z) ;
	}
}