using System;
class StraightLine {
	public static void Main() {
		double[] x = {5, 2, 4, 7, 9, 1} ;
		double[] y = {1, 9, 7, 4, 2, 5} ;
		int n = x.Length ;
		double xSum = 0 ;
		double ySum = 0 ;
		double xySum = 0 ;
		double xSquareSum = 0 ;
		for(int i=0; i<n; ++i) {
			xSum += x[i] ;
			ySum += y[i] ;
			xySum += (x[i] * y[i]) ;
			xSquareSum += (x[i] * x[i]) ;
		}
		double m = ((n * xySum) - (xSum * ySum)) / ((n * xSquareSum) - xSquareSum) ;
		double c = (ySum - (m * xSum)) / n ;
		Console.WriteLine("m = " + m) ;
		Console.WriteLine("c = " + c) ;
	}
}