using System ;
class Program {
	public static void Main() {
		Console.WriteLine("Enter values of constants....") ;
		Console.Write("a = ") ;
		int a = int.Parse(Console.ReadLine());
		Console.Write("b = ") ;
		int b = int.Parse(Console.ReadLine());
		Console.Write("c = ") ;
		int c = int.Parse(Console.ReadLine());
		Console.Write("d = ") ;
		int d = int.Parse(Console.ReadLine());
		Console.Write("m = ") ;
		int m = int.Parse(Console.ReadLine());
		Console.Write("n = ") ;
		int n = int.Parse(Console.ReadLine());
		
		int denominator = ((a * d) - (c * b)) ;
		
		if(denominator != 0) {
			int x1 = (((m * d) + (b * n)) / denominator) ;
			int x2 = (((n * a) + (m * c)) / denominator) ;
			Console.WriteLine("x1 = (md + bn) / (ad - cb) = {0}", x1) ;
			Console.WriteLine("x2 = (na + mc) / (ad - cb) = {0}", x2) ;
		}
		else {
			Console.WriteLine("Denominator must not be 0") ;
		}
	}
}