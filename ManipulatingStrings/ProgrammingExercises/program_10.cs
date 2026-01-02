using System ;

class Program {
	static void Disp(string[] arr) {
		foreach(string s in arr) {
			Console.Write(" " + s) ;
		}
	}
	public static void Main() {
		Console.Write("Enter length of the array, n = ") ;
		int n = int.Parse(Console.ReadLine()) ;
		string[] nameArr = new string[n] ;
		for(int i=0; i<n; ++i) {
			nameArr[i] = Console.ReadLine() ;
		}
		Console.WriteLine() ;
		Console.WriteLine("Before....") ;
		Disp(nameArr) ;
		
		Console.WriteLine() ;
		Array.Sort(nameArr) ;
		Console.WriteLine("Using Sort()...") ;
		Disp(nameArr) ;		
		
		Console.WriteLine() ;
		for(int i=0; i<n-1; ++i) {
			for(int j=i+1; j<n; ++j) {
				if(string.Compare(nameArr[i], nameArr[j]) > 0) {
					string temp = nameArr[i] ;
					nameArr[i] = nameArr[j] ;
					nameArr[j] = temp ;
				}
			}
		}
		Console.WriteLine("Using Compare()...") ;
		Disp(nameArr) ;
	}
}