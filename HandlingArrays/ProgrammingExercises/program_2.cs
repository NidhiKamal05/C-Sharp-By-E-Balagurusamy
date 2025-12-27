using System;
class Matrix {
	static void Display(int[,] arr) {
		for(int i=0; i<arr.GetLength(0); ++i) {
			for(int j=0; j<arr.GetLength(1); ++j) {
				Console.Write(" " + arr[i,j]) ;
			}
			Console.WriteLine() ;
		}
	}
	static void Initialize(ref int[,] arr) {
		for(int i=0; i<arr.GetLength(0); ++i) {
			for(int j=0; j<arr.GetLength(1); ++j) {
				// if(i == j || (i % 2 == j % 2)) {
				if(i % 2 == j % 2) {
					arr[i,j] = 1 ;
				}
				else {
					arr[i,j] = 0 ;
				}
			}
		}
	}
	public static void Main() {
		int[,] arr = new int[5,5] ;
		Initialize(ref arr);
		Display(arr) ;
	}
}