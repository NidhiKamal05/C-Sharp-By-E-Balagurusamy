using System ;
class Program {
	internal string Space(int n) {
		string s = "" ;
		for(int i=0; i<n; ++i) {
			s += " " ;
		}
		return s ;
	}
	public static void Main() {
		Program s = new Program() ;
		Console.Write("Enter number of spaces, n = ") ;
		int n = int.Parse(Console.ReadLine()) ;
		Console.Write(" 2" + s.Space(n) + "3") ;
		Console.WriteLine() ;
	}
}