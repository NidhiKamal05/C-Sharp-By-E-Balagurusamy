using System;

class RuppesToPaise {
	public static void Main() {
		Console.Write("Enter price = Rs.") ;
		decimal price = decimal.Parse(Console.ReadLine()) ;
		decimal priceInPaise = price * 100 ;
		Console.WriteLine("in paise = " + priceInPaise + " paise") ;
	}
}