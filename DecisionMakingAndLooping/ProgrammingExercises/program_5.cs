using System;
class Investment {
	public static void Main() {
		Console.Write("Enter the principal amt: ") ;
		double p = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter the rate of interest: ") ;
		double r = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter no. of year: ") ;
		double n = double.Parse(Console.ReadLine()) ;
		while(n > 0) {
			// double v = p * (1 + r) ;
			double v = p * (1 + (r/100)) ;
			p = v ;
			--n ;
		}
		Console.WriteLine("Value of money is: " + p) ;
	}
}