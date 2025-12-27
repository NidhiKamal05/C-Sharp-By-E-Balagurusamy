using System;
class MergeArrays {
	static void Display(int[] arr) {
		foreach(int i in arr) {
			Console.Write(" " + i) ;
		}
		Console.WriteLine() ;
	}
	
	static int[] Merge(int[] arr1, int[] arr2) {		
		int l1 = arr1.Length, l2 = arr2.Length ;
		
		int l3 = l1 + l2 ;		
		int[] arr = new int[l3] ;
		
		for(int i=0; i<l1; ++i) {
			arr[i] = arr1[i] ;
		}
		
		int j = 0 ;
		for(int i=l1; i<l3; ++i) {
			arr[i] = arr2[j++] ;
		}
		
		return arr ;
	}
	
	public static void Main() {
		Console.Write("Enter length of array1 : ") ;
		int l1 = int.Parse(Console.ReadLine()) ;
		
		int[] arr1 = new int[l1] ;
		
		Console.WriteLine("Enter elements of array1...") ;
		for(int i=0; i<l1; ++i) {
			arr1[i] = int.Parse(Console.ReadLine()) ;
		}
		
		Console.WriteLine() ;
		
		Console.Write("Enter length of array2 : ") ;
		int l2 = int.Parse(Console.ReadLine()) ;
		
		int[] arr2 = new int[l2] ;
		
		Console.WriteLine("Enter elements of array2...") ;
		for(int i=0; i<l2; ++i) {
			arr2[i] = int.Parse(Console.ReadLine()) ;
		}
		
		Console.WriteLine() ;
		
		int[] arr3 = Merge(arr1, arr2) ;
		
		Console.Write("Array 1 = ") ;
		Display(arr1) ;
		
		Console.Write("Array 2 = ") ;
		Display(arr2) ;
		
		Console.Write("Merged Array = ") ;
		Display(arr3) ;
	}
}