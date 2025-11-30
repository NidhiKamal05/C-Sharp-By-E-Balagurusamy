using System;

class Program {
	public static void Main() {
		int depreciation = 100, purchasePrice = 75, yearsOfService = 5 ;
		int savageValue = purchasePrice - (depreciation * yearsOfService) ;
		Console.WriteLine("purchasePrice = " + purchasePrice) ;
		Console.WriteLine("yearsOfService = " + yearsOfService) ;
		Console.WriteLine("depreciation = " + depreciation) ;
		Console.WriteLine("savageValue = " + savageValue) ;
	}
}