using System;

class OperationsOnFloatingPoint {
	public static void Main() {
		Console.Write("Enter num1 = ") ;		
		double num1 = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter num2 = ") ;
		double num2 = double.Parse(Console.ReadLine()) ;
		double sum = num1+num2 ;
		double diff = num1-num2 ;
		double prod = num1*num2 ;
		double div = num1/num2 ;
		double mod = num1%num2 ;
		Console.WriteLine("Sum = " + sum) ;
		Console.WriteLine("Difference = " + diff) ;
		Console.WriteLine("Product = " + prod) ;
		Console.WriteLine("Integer division = " + div) ;
		Console.WriteLine("Modulus division = " + mod) ;
	}
}