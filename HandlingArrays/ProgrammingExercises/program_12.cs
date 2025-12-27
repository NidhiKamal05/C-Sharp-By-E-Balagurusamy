using System;
class Check {
	static bool IsFound(int[] arr, int k) {
		foreach(int i in arr) {
			if(k == i) {
				return true ;
			}
		}
		return false ;
	}
	
	public static void Main() {
		Console.Write("Enter length of array : ") ;
		int l = int.Parse(Console.ReadLine()) ;
		
		int[] arr = new int[l] ;
		
		Console.WriteLine("Enter elements of array...") ;
		for(int i=0; i<l; ++i) {
			arr[i] = int.Parse(Console.ReadLine()) ;
		}
		
		Console.Write("Enter an integer to find in the above array : ") ;
		int k = int.Parse(Console.ReadLine()) ;
		
		Console.WriteLine() ;
		
		bool ans = IsFound(arr, k) ;
		
		Console.WriteLine(ans) ;
	}
}