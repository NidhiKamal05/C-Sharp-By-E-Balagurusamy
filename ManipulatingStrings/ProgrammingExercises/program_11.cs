using System ;

class Pattern {
	public static void Main() {
		string s = "123456789" ;
		for(int i=0; i<s.Length; ++i) {
			int k = int.Parse(s[i].ToString()) ;
			for(int j=0; j<i; ++j) {
				Console.Write(" " + k++) ;
			}
			Console.Write(" " + k) ;
			for(int j=0; j<i; ++j) {
				Console.Write(" " + --k) ;
			}
			Console.WriteLine() ;
		}
	}
}

/*using System ;

class Pattern {
	public static void Main() {
		string s = "123456789" ;
		for(int i=0; i<s.Length; ++i) {
			Console.WriteLine("----" + i) ;
			for(int j=0; j<i; ++j) {
				Console.Write(" " + s[k++]) ;
			}
			Console.Write(" " + s[k]) ;
			for(int j=0; j<i; ++j) {
				Console.Write(" " + s[--k]) ;
			}
			Console.WriteLine() ;
		}
	}
}*/