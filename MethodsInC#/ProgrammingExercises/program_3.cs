using System ;
class Interest {
	internal void calcMoney(double p, double r, double t, out double val) {
		double v = 0 ;
		while(t != 0) {
			v = p * (1 + r) ;
			p = v ;
			--t ;
		}
		val = p ;
	}
	public static void Main() {
		Interest i = new Interest() ;
		double p = 1000 ;
		double r = 0.8 ;
		double t = 5 ;		
		double val ;
		
		i.calcMoney(p, r, t, out val) ;
		
		Console.WriteLine();
		Console.WriteLine("Value of " + p + " after " + t + " years at the interest rate " + r + " = " + val) ;
	}
}