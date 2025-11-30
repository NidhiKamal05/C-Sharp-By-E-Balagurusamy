using System;

class Program {
	public static void Main() {
		Console.Write("Enter a real number = ") ;
		double n = double.Parse(Console.ReadLine()) ;
		double l = Math.Floor(n) ;
		double s = Math.Ceiling(n) ;
		Console.Write("Smallest integer not less than the number = " + s) ;
		Console.Write(" The given number = ", n) ;
		Console.WriteLine(" Largest integer not greater than the number = " + l) ;
	}
}