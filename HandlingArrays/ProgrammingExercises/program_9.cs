using System;
class TwoDArray
{
	static void Display(int[,] arr) {
		for(int i=0; i<arr.GetLength(0); ++i) {
			for(int j=0; j<arr.GetLength(1); ++j) {
				Console.Write(" " + arr[i,j]) ;
			}
			Console.WriteLine() ;
		}
	}
	static void MatMul(int[,] A, int[,] B, ref int[,] C) {
		for(int i=0; i<C.GetLength(0); ++i) {
			for(int j=0; j<C.GetLength(1); ++j) {
				for(int k=0; k<A.GetLength(1); ++k) {
					C[i, j] = A[i, k] * B[k, j] ;
				}
			}
		}
	}
	public static void Main()
	{
		int[,] A = {
			{0, 1},
			{5, 6}
		} ;
		int[,] B = {
			{1},
			{2},
			{3}
		} ;
		int m = A.GetLength(0) ;
		int n = B.GetLength(1) ;
		int[,] C = new int[m,n] ;
		Console.WriteLine("A = ") ;
		Display(A) ;
		Console.WriteLine("---------------------");
		Console.WriteLine("B = ") ;
		Display(B) ;
		Console.WriteLine() ;
		
		MatMul(A, B, ref C) ;
		
		Console.WriteLine("---------------------");
		Console.WriteLine("A * B = C") ;
		Console.WriteLine("C = ") ;
		Display(C) ;
	}
}