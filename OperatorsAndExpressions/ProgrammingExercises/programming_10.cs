using System;

class Distance {
	public static void Main() {
		Console.Write("Enter initial velocity, u = ") ;
		double u = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter acceleration, a = ") ;
		double a = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter time, t = ") ;
		double t = double.Parse(Console.ReadLine()) ;
		
		double d = (u * t) + ((a * t * t) / 2) ;
		
		Console.WriteLine("Distance = " + d) ;
	}
}