using System ;

class CharCount {
	public static void Main(string[] args) {
		if(args.Length == 0) {
			Console.WriteLine("No command line argument....") ;
		}
		else {
			Console.Write("Enter any character, ch = ") ;
			char ch = char.Parse(Console.ReadLine()) ;
			int pos = args[0].IndexOf(ch) ;
			if(pos == -1) {
				Console.WriteLine("Not Found....") ;
			}
			else {
				int cnt = 0 ;
				foreach(char c in args[0]) {
					if(c == ch) {
						++cnt ;
					}
				}
				Console.WriteLine(ch + " is occurred " + cnt + " times in " + args[0]) ;
			}
		}
	}
}