using System;

class Program {
	public static void Main() {
		Console.Write("Enter demand rate (items per unit time) = ") ;
		double d = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter setup costs (per order) ") ;
		double s = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter holding cost (per item per unit time) = ") ;
		double h = double.Parse(Console.ReadLine()) ;
		
		double EOQ = Math.Sqrt((2 * d * s) / h) ;
		double TBO = Math.Sqrt((2 * s) / (d * h)) ;
		
		Console.WriteLine() ;
		Console.WriteLine("EOQ = " + EOQ) ;
		Console.WriteLine("TBO = " + TBO) ;
	}
}