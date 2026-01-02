using System ;

class WordCount {
	public static void Main() {
		Console.WriteLine("Enter a line of text....") ;
		String s = Console.ReadLine() ;	
		int cnt = 0 ;
		foreach(char c in s) {
			if(c == ' ') {
				++cnt ;
			}
		}
		++cnt ;
		Console.WriteLine("Number of words in " + s + " = " + cnt) ;
	}
}