using System;
class Temperature {
	static void Display(int[,] arr) {
		for(int i=0; i<arr.GetLength(0); ++i) {
			for(int j=0; j<arr.GetLength(1); ++j) {
				Console.Write(" " + arr[i,j]) ;
			}
			Console.WriteLine() ;
		}
	}
	static void HighestAndLowestTemp(int[,] arr, int col) {
		int lowTemp = 100, highTemp = 0 ;
		for(int i=0; i<arr.GetLength(0); ++i) {
			if(arr[i, col] > highTemp) {
				highTemp = arr[i, col] ;
			}
			if(arr[i, col] < lowTemp) {
				lowTemp = arr[i, col] ;
			}
			// highTemp = Math.max(highTemp, arr[i, col]) ;
			// lowTemp = Math.min(lowTemp, arr[i, col]) ;
		}
		Console.WriteLine("Highest Temperature of the city " + col + " = " + highTemp) ;
		Console.WriteLine("Lowest Temperature of the city " + col + " = " + lowTemp) ; ;
	}
	public static void Main() {
		int[,] arr = {
			{5, 10, 15, 20, 25},
			{7, 12, 17, 22, 27},
			{6, 11, 16, 21, 26},
			{8, 13, 18, 23, 28},
			{9, 14, 19, 24, 29},
			{4, 9, 14, 19, 24}
		} ;
		Display(arr) ;
		int city = 2 ;
		HighestAndLowestTemp(arr, city) ;
	}
}