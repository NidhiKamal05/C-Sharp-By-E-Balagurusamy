using System ;
class FloydTriangle {
	public static void Main() {
		// (a)
		int num = 1 ;
		for(int i=0; i<=12; ++i) {
			for(int j=0; j<i+1; ++j) {
				Console.Write(num + " ") ;
				++num ;
			}
			Console.WriteLine() ;
		}		
		
		Console.WriteLine() ;
		Console.WriteLine() ;
		// (b)
		int n = 1 ;
		for(int i=0; i<5; ++i) {
			n = i % 2 != 0 ? 0 : 1 ;
			for(int j=0; j<i+1; ++j) {
				Console.Write(n + " ") ;
				n = n == 0 ? 1 : 0 ;
			}
			Console.WriteLine() ;
		}
	}
}