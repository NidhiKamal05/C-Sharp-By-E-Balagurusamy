using System ;

class PascalTriangle {
	public static void Main() {
		const int rows = 10 ;
		int[][] pascal = new int[rows][] ;
		for(int i=0; i<rows; ++i) {
			pascal[i] = new int[i+1] ;
			for(int j=0; j<i+1; ++j) {
				if((j == 0) || (j == i)) {
					pascal[i][j] = 1 ;
				}
				else {
					pascal[i][j] = pascal[i-1][j-1] + pascal[i-1][j] ;
				}
			}
		}
		for(int i=0; i<rows; ++i) {
			for(int j=0; j<i+1; ++j) {
				Console.Write(" " + pascal[i][j]) ;
			}
			Console.WriteLine() ;
		}
	}
}