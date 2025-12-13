using System;
class Patterns {
	public static void Main() {
		// (a)
		for(int i=1; i<=5; ++i) {
			for(int j=0; j<i; ++j) {
				Console.Write(" " + i) ;
			}
			Console.WriteLine() ;
		}
		
		Console.WriteLine() ;
		
		// (2)
		for(int i=5; i>=1; --i) {
			for(int j=i; j>0; --j) {
				Console.Write(" $") ;
			}
			Console.WriteLine() ;
		}
		
		Console.WriteLine() ;
		
		// (c)
		int maxSpace = 5 ;
		for(int i=1; i<=5; ++i) {
			for(int j=maxSpace; j>=1; --j) {
				Console.Write(" ") ;
			}
			for(int j=0; j<i; ++j) {
				Console.Write(" " + i) ;
			}
			Console.WriteLine() ;
			--maxSpace ;
		}
	}
}