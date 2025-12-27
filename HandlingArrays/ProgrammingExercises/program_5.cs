using System;
class Election {
	static int spoiltBallots = 0 ;
	static void VoteCount(int[] arr) {
		for(int i=0; i<arr.Length; ++i) {			
			Console.Write(" " + arr[i]) ;
		}
	}
	static void VoteCast(ref int[] arr) {
		Console.WriteLine("Input vote from 1 to 5 : ") ;
		int vote = int.Parse(Console.ReadLine()) ;
		if(vote > 5 || vote < 1) {
			++spoiltBallots ;
		}
		else {
			++arr[vote - 1] ;
		}
	}
	public static void Main() {
		int[] arr = new int[5] ;
		bool cond = true ;
		int option ;
		while(cond) {
			Console.WriteLine() ;
			Console.WriteLine("Choose option...");
			Console.WriteLine("1. Vote Cast");
			Console.WriteLine("2. Spoilt Ballots");
			Console.WriteLine("3. Vote Count");
			Console.WriteLine("4. Exit");
			option = int.Parse(Console.ReadLine()) ;
			switch(option) {
				case 1:
					VoteCast(ref arr) ;
					break ;
				case 2:
					Console.WriteLine("Number of spoilt ballots = " + spoiltBallots) ;
					break ;
				case 3:
					VoteCount(arr) ;
					break ;
				case 4:
					cond = false ;
					break ;
				default:
					Console.WriteLine("Wrong option....") ;
					Console.WriteLine("Press y for continue or else for exit....") ;
					char ch = char.Parse(Console.ReadLine()) ;				
					if(ch != 'y') {
						cond = false ;
					}
					break ;
			}
		}
	}
}