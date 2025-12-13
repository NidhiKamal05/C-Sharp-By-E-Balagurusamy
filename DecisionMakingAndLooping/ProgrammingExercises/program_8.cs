using System;
class DollarToRuppee {
	public static void Main() {
		Console.Write("Enter an integer, m = ") ;
		int m = int.Parse(Console.ReadLine()) ;
		int i=0;
		do {
			Console.Write("Enter amt in dollar = ") ;
			double dollar = double.Parse(Console.ReadLine()) ;
			double ruppee = dollar * 90.5271 ;
			Console.WriteLine("$" + dollar + " = Rs." + ruppee) ;
			Console.WriteLine() ;
			++i ;
		}
		while(i < m) ;
	}
}