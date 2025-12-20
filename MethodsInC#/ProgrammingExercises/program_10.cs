using System ;
class Program {
	internal bool IsPrime(int num) {
		for(int i=2; i<num; ++i) {
			if(num % i == 0) {
				return false ;
			}
		}
		return true ;
	}
	public static void Main() {
		Program p = new Program() ;

		Console.Write("Enter an integer, num = ") ;
		int num = int.Parse(Console.ReadLine()) ;
		
		bool ans = p.IsPrime(num) ;
		
		Console.WriteLine();
		Console.WriteLine(num + " is a prime number. -> " + ans) ;
	}
}