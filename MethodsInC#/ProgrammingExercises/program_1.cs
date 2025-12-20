using System ;
class Print {
	public void PrintLine() {
		for(int i=0; i<20; ++i) {
			Console.Write("^") ;
		}
	}
	public static void Main() {
		Print p = new Print() ;
		p.PrintLine() ;
	}
}