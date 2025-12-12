using System ;
class Program {
	public static void Main() {
		Console.WriteLine("Enter marks in....") ;
		Console.Write("Maths = ") ;
		int m = int.Parse(Console.ReadLine());
		Console.Write("Physics = ") ;
		int p = int.Parse(Console.ReadLine());
		Console.Write("Chemistry = ") ;
		int c = int.Parse(Console.ReadLine());
		
		if(((m >= 60) && (p >= 50) && (c >= 40) && (m + p + c >= 200)) || (m + p >= 150)) {
			Console.WriteLine("Eligible....") ;
		}
		else {
			Console.WriteLine("Not Eligible....") ;
		}
	}
}