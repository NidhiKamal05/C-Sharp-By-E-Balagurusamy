using System;

class OperationsOnInteger {
	public static void Main() {
		Console.Write("Enter num1 = ") ;		
		int num1 = int.Parse(Console.ReadLine()) ;
		Console.Write("Enter num2 = ") ;
		int num2 = int.Parse(Console.ReadLine()) ;
		int sum = num1+num2 ;
		int diff = num1-num2 ;
		int prod = num1*num2 ;
		int div = num1/num2 ;
		int mod = num1%num2 ;
		Console.WriteLine("Sum = " + sum) ;
		Console.WriteLine("Difference = " + diff) ;
		Console.WriteLine("Product = " + prod) ;
		Console.WriteLine("Integer division = " + div) ;
		Console.WriteLine("Modulus division = " + mod) ;
	}
}