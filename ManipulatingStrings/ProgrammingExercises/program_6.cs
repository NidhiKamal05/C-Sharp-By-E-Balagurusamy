using System ;
using System.Text ;

class Rearrange {
	public static void Main() {
		Console.WriteLine("Enter a string of three words.....") ;
		string s = Console.ReadLine() ;
		
		StringBuilder sb = new StringBuilder(s) ;
		sb.Replace(' ', '_') ;
		
		string s1 = sb.ToString() ;
		
		Console.WriteLine("Before = " + s) ;
		Console.WriteLine("After = " + s1) ;
	}
}