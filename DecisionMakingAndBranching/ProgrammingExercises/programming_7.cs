using System ;
class SquareRoot {
	public static void Main() {
		for(double i=0; i<10; ++i) {
			Console.Write(i + "   ") ;
			for(double j=0; j<1; j+=0.1) {
				Console.Write(Math.Round((Math.Sqrt(i+j))*100)/100 + " ") ;
			}
			Console.WriteLine() ;
		}
	}
}