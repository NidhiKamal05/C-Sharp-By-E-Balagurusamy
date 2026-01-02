using System ;
using System.Text ;

class Program {
	public static void Main() {
		Console.Write("Enter first name: ") ;
		string fName = Console.ReadLine() ;
		Console.Write("Enter last name: ") ;
		string lName = Console.ReadLine() ;
		
		string name = fName + " " + lName ;
		
		StringBuilder sb = new StringBuilder(fName) ;
		sb.Append(" ") ;
		sb.Append(lName) ;
		
		string fullName = sb.ToString() ;
		
		Console.WriteLine("fName = " + fName) ;
		Console.WriteLine("lName = " + lName) ;
		Console.WriteLine("name = " + name) ;
		Console.WriteLine("fullName = " + fullName) ;
	}
}