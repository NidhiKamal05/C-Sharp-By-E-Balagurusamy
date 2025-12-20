using System ;
class Calc {
	internal void Product(int a, int b, out int c) {
		c = a * b ;
	}
	public static void Main() {
		Calc c = new Calc() ;
		int x = 100 ;
		int y = 295 ;	
		int z ;
		
		c.Product(x, y, out z) ;
		
		Console.WriteLine();
		Console.WriteLine(x + " * " + y + " = " + z) ;
	}
}