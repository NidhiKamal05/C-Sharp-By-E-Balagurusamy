using System ;

class CommandLine {
	public static void Main(string[] args) {
		if(args.Length == 0) {
			Console.WriteLine("No Arguments...") ;
			return ;
		}
		Console.Write(args[2]) ;
		Console.Write(" ") ;
		Console.Write(args[0]) ;
		Console.Write(" ") ;
		Console.WriteLine(args[1]) ;
	}
}