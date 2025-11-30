using System;

class FahrenheitToCelsius {
	public static void Main() {
		Console.Write("Enter temperature in fahrenheit = ") ;
		double f = double.Parse(Console.ReadLine()) ;
		double c = (f - 32) / 1.8 ;
		Console.WriteLine("Temperature in celsius = " + c) ;
		
		Console.WriteLine() ;
		Console.WriteLine(" Fahrenheit | Celsius") ;
		Console.WriteLine(" {0,10} | {1, 7:F2}", f, c) ;
	}
}