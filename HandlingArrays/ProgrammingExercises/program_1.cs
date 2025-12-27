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
	static void Rev(ref int[,] arr) {
		for(int x=0; x<arr.GetLength(0); ++x) {
			int i=0, j = arr.GetLength(1) - 1 ;
			while(i < j) {
				int temp = arr[x,i] ;
				arr[x,i] = arr[x,j] ;
				arr[x,j] = temp ;
				++i ;
				--j ;
			}
		}
	}
	public static void Main()
	{
		int[,] arr = {
			{0, 1, 2, 3, 4},
			{5, 6, 7, 8, 9},
			{4, 3, 2, 1, 0},
			{9, 8, 7, 6, 5},
			{0, 5, 4, 9, 2}
		} ;
		Display(arr) ;
		Console.WriteLine() ;
		Console.WriteLine("---------------------");
		Rev(ref arr) ;
		Display(arr) ;
	}
}