using System;
class JumpStatements {
	public static void Main() {
		Console.Write("Enter an integer, num = ") ;
		int num = int.Parse(Console.ReadLine()) ;
		switch(num) {
			case 1:
				break ;
			case 2:
				goto case 1 ;
			default:
				for(int i=1; i<=5; ++i) {
					if(i == 2) {
						continue ;
					}
					Console.Write(" " + i) ;
				}
				break ;
		}
	}
}