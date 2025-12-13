using System;
class DigitSum {
	public static void Main() {
		Console.Write("Enter an integer, num = ") ;
		int num = int.Parse(Console.ReadLine()) ;
		int sum = 0 ;
		while(num != 0) {
			sum += (num % 10) ;
			num /= 10 ;
		}
		Console.WriteLine("Digits sum = " + sum) ;
	}
}