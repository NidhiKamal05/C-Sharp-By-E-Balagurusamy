using System ;
class Sort {
	internal void SortIntArray(ref int[] arr) {
		int n = arr.Length ;
		for(int i=0; i<n-1; ++i) {
			for(int j=i+1; j<n; ++j) {
				if(arr[i] > arr[j]) {
					int temp = arr[i] ;
					arr[i] = arr[j] ;
					arr[j] = temp ;
				}
			}
		}
	}
	public static void Main() {
		int[] arr = {11, 5, 13, 9, 4, 2, 10} ;
		Console.WriteLine("Before....") ;
		foreach(int el in arr) {
			Console.Write(" " + el) ;
		}
		Sort s = new Sort() ;
		s.SortIntArray(ref arr) ;
		Console.WriteLine() ;
		Console.WriteLine("After....") ;
		foreach(int el in arr) {
			Console.Write(" " + el) ;
		}
	}
}