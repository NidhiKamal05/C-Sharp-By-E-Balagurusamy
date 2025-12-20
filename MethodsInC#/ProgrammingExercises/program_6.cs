using System ;
class StandardDeviation {
	/** BOTH WORKS **/
	// internal double StdDev(int[] arr, double mean) {
		// double s = 0 ;
		// foreach(int el in arr) {
			// s += Math.Pow((el - mean), 2) ;
		// }
		// return Math.Sqrt(s / arr.Length) ;
	// }
	
	internal double StdDev(int[] arr) {
		double mean = Mean(arr) ;
		double s = 0 ;
		foreach(int el in arr) {
			s += Math.Pow((el - mean), 2) ;
		}
		return Math.Sqrt(s / arr.Length) ;
	}
	
	internal double Mean(int[] arr) {
		int sum = 0 ;
		foreach(int el in arr) {
			sum += el ;
		}
		return sum / arr.Length ;
	}
	
	public static void Main() {
		StandardDeviation s = new StandardDeviation() ;
		int[] arr = {10, 5, 15, 7, 2, 9, 1, 11, 4, 3} ;
		Console.WriteLine("Array elements....") ;
		foreach(int el in arr) {
			Console.Write(" " + el) ;
		}
		
		Console.WriteLine();
		
		double mean = s.Mean(arr) ;
		// double stdD = s.StdDev(arr, mean) ;
		double stdD = s.StdDev(arr) ;
		
		Console.WriteLine("Mean of array elements = " + mean);
		Console.WriteLine("Standard deviation of array elements = " + stdD) ;
	}
}