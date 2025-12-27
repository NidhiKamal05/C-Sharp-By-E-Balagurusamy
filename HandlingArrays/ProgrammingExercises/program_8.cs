using System;
class Sorting {
	static void Disp(int[] arr) {
		foreach(int i in arr) {
			Console.Write(" " + i) ;
		}
		Console.WriteLine() ;
	}
	public static void Main() {
		int[] A = {0, 2, 4, 6, 8} ;
		int[] B = {1, 9} ;
		int[] C = new int[A.Length + B.Length] ;
		for(int i=0; i<A.Length; ++i) {
			C[i] = A[i] ;
		}
		for(int i=A.Length, j=0; i<C.Length && j<B.Length; ++i) {
			C[i] = B[j++] ;
		}
		Array.Sort(C) ;
		Console.WriteLine("Display A....") ;
		Disp(A) ;
		Console.WriteLine("Display B....") ;
		Disp(B) ;
		Console.WriteLine("Display C....") ;
		Disp(C) ;
	}
}