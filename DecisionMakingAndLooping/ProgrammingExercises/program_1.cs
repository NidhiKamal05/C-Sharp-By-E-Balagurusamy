using System;
class Reverse {
	public static void Main() {
		Console.Write("Enter an integer, num = ") ;
		int num = int.Parse(Console.ReadLine()) ;
		Console.WriteLine("original number = " + num) ;
		int revNum = 0 ;
		while(num != 0) {
			revNum = (revNum * 10) + (num % 10) ;
			num /= 10 ;
		}
		Console.WriteLine("reverse number = " + revNum) ;
	}
}