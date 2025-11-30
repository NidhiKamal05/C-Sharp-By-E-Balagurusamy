using System;

class Circle {
	public static void Main() {
		double r = 12.5 ;
		double c = 2 * Math.PI * r ;
		double area = Math.PI * r * r ;
		Console.WriteLine("Circumference = " + c) ;
		Console.WriteLine("Area = " + area) ;
	}
}