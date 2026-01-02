using System ;

class Program {
	public static void Main() {
		string s = "0123456789" ;
		int i = 0 ;
		while(i < s.Length) {
			Console.WriteLine("Character at " + i + "th index = " + s[i++]) ;
		}
	}
}