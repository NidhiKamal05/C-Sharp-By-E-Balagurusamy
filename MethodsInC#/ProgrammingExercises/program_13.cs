using System ;
class Program {
	internal int Largest(int a, int b, int c) {
		return a > b ? (a > c ? a : c) : (b > c ? b : c) ; 
	}
	public static void Main() {
		Program p = new Program() ;
		int x = 100 ;
		int y = 295 ;	
		int z = 300 ;
		
		int ans = p.Largest(x, y, z) ;
		
		Console.WriteLine("Largest from " + x + ", " + y + " and " + z + " is " + ans);
	}
}