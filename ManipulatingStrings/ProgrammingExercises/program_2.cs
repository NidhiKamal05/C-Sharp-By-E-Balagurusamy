using System ;

class DemonstrateCopyAndConcat {
	public static void Main() {
		string s1 = "Hello " ;
		string s2 = string.Copy(s1) ;
		string s3 = "Everyone" ;
		string s4 = string.Concat(s1, s3) ;
		Console.WriteLine("s1 = " + s1) ;
		Console.WriteLine("s2 = " + s2) ;
		Console.WriteLine("s3 = " + s3) ;
		Console.WriteLine("s4 = " + s4) ;
	}
}