using System ;

class CharCount {
	public static void Main() {
		Console.WriteLine("Enter a line of text....") ;
		String s = Console.ReadLine() ;
		Console.Write("Enter any character, ch = ") ;
		char ch = char.Parse(Console.ReadLine()) ;	
		int cnt = 0 ;
		foreach(char c in s) {
			if(c == ch) {
				++cnt ;
			}
		}
		if(cnt == 0) {
			Console.WriteLine(ch + " is not found " + " in " + s) ;
		}
		else {
			Console.WriteLine(ch + " is occurred " + cnt + " times in " + s) ;
		}
	}
}