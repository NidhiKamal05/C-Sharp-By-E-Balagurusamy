using System ;

class Rearrange {
	public static void Main() {
		Console.Write("Enter a string: ") ;
		string s = Console.ReadLine() ;
		
		char[] arr = s.ToCharArray() ;
		Array.Sort(arr) ;
		
		string s1 = new string(arr) ;
		
		Console.WriteLine("Original string = " + s) ;
		Console.WriteLine("Rearranged string = " + s1) ;
	}
}