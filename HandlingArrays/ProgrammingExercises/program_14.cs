using System;
class ReverseArray {
	static void Display(int[] arr) {
		foreach(int i in arr) {
			Console.Write(" " + i) ;
		}
		Console.WriteLine() ;
	}
	
	static void RevArr(ref int[] arr) {		
		int i = 0, j = arr.Length - 1 ;
		
		while(i < j) {
			int temp = arr[i] ;
			arr[i] = arr[j] ;
			arr[j] = temp ;
			++i ;
			--j ;
		}
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
		
		Console.Write("Before....") ;
		Display(arr) ;
		
		RevArr(ref arr) ;
		
		Console.Write("After....") ;
		Display(arr) ;
	}
}