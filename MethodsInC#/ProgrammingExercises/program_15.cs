using System ;
class Program {
	internal int Largest(int[] arr) {
		int maxEl = 0 ;
		foreach(int el in arr) {
			if(el > maxEl) {
				maxEl = el ;
			}
		}
		return maxEl ;
	}
	internal double Average(int[] arr) {
		int sum = 0 ;
		foreach(int el in arr) {
			sum += el ;
		}
		return sum / arr.Length ;
	}
	public static void Main() {
		Program p = new Program() ;
		int[] arr = {10, 5, 15, 7, 2, 9, 1, 11, 4, 3} ;
		Console.WriteLine("Array elements....") ;
		foreach(int el in arr) {
			Console.Write(" " + el) ;
		}
		
		Console.WriteLine();
		
		int largest = p.Largest(arr) ;
		double avg = p.Average(arr) ;
		
		Console.WriteLine("Largest array element = " + largest) ;
		Console.WriteLine("Average of array elements = " + avg);
	}
}