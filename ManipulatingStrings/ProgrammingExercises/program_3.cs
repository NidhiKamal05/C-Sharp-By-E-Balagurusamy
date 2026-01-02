using System ;

class IllustrateReadLine {
	public static void Main() {
		Console.Write("Enter first name: ") ;
		string fName = Console.ReadLine() ;
		Console.Write("Enter last name: ") ;
		string lName = Console.ReadLine() ;
		
		Console.WriteLine() ;
		
		Console.WriteLine("First name = " + fName) ;
		Console.WriteLine("Last name = " + lName) ;
	}
}