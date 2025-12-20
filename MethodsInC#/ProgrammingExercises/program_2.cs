using System ;
class Print {
	internal void PrintLine() {
		for(int i=0; i<20; ++i) {
			Console.Write("*") ;
		}
	}
	public static void Main() {
		Print p = new Print() ;
		
		Console.WriteLine();
		
		p.PrintLine() ;
		Console.WriteLine();
		Console.Write("   C# Programming");
		Console.WriteLine() ;
		p.PrintLine() ;
		
		Console.WriteLine();
	}
}