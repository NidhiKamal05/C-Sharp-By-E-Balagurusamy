using System ;
class Print {
	internal void PrintLine(char ch, int len) {
		for(int i=0; i<len; ++i) {
			Console.Write(ch) ;
		}
	}
	public static void Main() {
		Print p = new Print() ;
		
		// for(int i=0; i<3; ++i) {
			// Console.WriteLine();
			// Console.Write("Enter a character : ") ;
			// char ch = char.Parse(Console.ReadLine()) ;
			// Console.Write("Enter length : ") ;
			// int len = int.Parse(Console.ReadLine()) ;						
			// p.PrintLine(ch, len) ;
		// }
		
		Console.WriteLine();
		p.PrintLine('A', 10) ;
		Console.WriteLine();
		p.PrintLine('Z', 15) ;
		Console.WriteLine();
		p.PrintLine('W', 25) ;
		
		Console.WriteLine();
	}
}