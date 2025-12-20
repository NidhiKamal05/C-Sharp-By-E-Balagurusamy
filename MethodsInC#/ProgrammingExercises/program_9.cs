using System ;
class Program {
	internal double RoundUp(double decimalNumber, int decimalPlaces) {
		double m = Math.Pow(10, decimalPlaces) ;
		return (int)(decimalNumber * m) / m ;
	}
	public static void Main() {
		Program s = new Program() ;
		Console.Write("Enter a decimal number, num = ") ;
		double num = double.Parse(Console.ReadLine()) ;
		Console.Write("Enter number of decimal places, n = ") ;
		int n = int.Parse(Console.ReadLine()) ;
		double m = s.RoundUp(num, n) ;
		Console.WriteLine("After round off to " + n + " places = " + m) ;
	}
}