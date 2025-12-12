using System ;
class Program {
	public static void Main() {
		// int[] marks = {50, 55, 45, 30, 12, 75, 80, 95, 66, 90, 86} ;
		int[] marks = {12, 30, 45, 50, 55, 66, 75, 80, 86, 90, 95} ;
		int r1 = 0, r2 = 0, r3 = 0, r4 = 0 ;
		Console.WriteLine("Enter marks of a student....") ;
		foreach(int mark in marks) {
			if(mark > 80) {
				++r1 ;
			}
			else if(mark > 60) {
				++r2 ;
			}
			else if(mark > 40) {
				++r3 ;
			}
			else {
				++r4 ;
			}
		}
		Console.WriteLine("No. of students who have obtained marks in the range 81 to 100 = {0}", r1) ;
		Console.WriteLine("No. of students who have obtained marks in the range 61 to 80 = {0}", r2) ;
		Console.WriteLine("No. of students who have obtained marks in the range 41 to 60 = {0}", r3) ;
		Console.WriteLine("No. of students who have obtained marks in the range 0 to 40 = {0}", r4) ;
	}
}