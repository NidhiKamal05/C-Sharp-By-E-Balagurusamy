using System ;
class Program {
	public static void Main() {
		Console.WriteLine("Enter value of....") ;
		Console.Write("x = ") ;
		int x = int.Parse(Console.ReadLine());
		int y ;
		
		// USING NESTED IF STATEMENTS
		if(x >= 0) {
			if(x > 0) {
				y = 1 ;
			}
			else {
				y = 0 ;
			}
		}
		else {
			y = -1 ;
		}
		
		// USING ELSE IF STATEMENTS
		// if(x > 0) {
			// y = 1 ;
		// }
		// else if(x < 0) {
			// y = -1 ;
		// }
		// else {
			// y = 0 ;
		// }
		
		// USING CONDITIONAL OPERATOR ?
		// y = ((x > 0) ? 1 : ((x < 0) ? -1 : 0)) ;

		Console.WriteLine("x = " + x + " and y = " + y) ;
	}
}