using System;
class Alternate {
	static void Display(int[] arr) {
		int l = arr.Length ;
		for(int i=0; i<l; i+=2) {
			Console.Write(" " + arr[i]) ;
		}
		if(l > 1) {
			Console.WriteLine() ;
			for(int i=1; i<l; i+=2) {
				Console.Write(" " + arr[i]) ;
			}
		}
		Console.WriteLine() ;
	}
	
	public static void Main() {
		Console.Write("Enter length of array : ") ;
		int l = int.Parse(Console.ReadLine()) ;
		
		int[] arr = new int[l] ;
		
		Console.WriteLine("Enter elements of array...") ;
		for(int i=0; i<l; ++i) {
			arr[i] = int.Parse(Console.ReadLine()) ;
		}
		
		Console.WriteLine() ;
		
		Display(arr) ;
	}
}