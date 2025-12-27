using System;
class MinMax {	
	public static void Main() {
		Console.Write("Enter length of array : ") ;
		int l = int.Parse(Console.ReadLine()) ;
		
		int[] arr = new int[l] ;
		
		Console.WriteLine("Enter elements of array...") ;
		for(int i=0; i<l; ++i) {
			arr[i] = int.Parse(Console.ReadLine()) ;
		}
		
		int maxVal = int.MinValue ;
		int minVal = int.MaxValue ;
		
		foreach(int i in arr) {
			maxVal = Math.Max(maxVal, i) ;
			minVal = Math.Min(minVal, i) ;
		}
		
		Console.WriteLine() ;
		
		Console.WriteLine("Max Val = " + maxVal) ;
		Console.WriteLine("Min Val = " + minVal) ;
	}
}