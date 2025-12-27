using System;
class Result {
	static void PrintResult(int[] roll, int[] sub1, int[] sub2, int[] sub3, int[] total) {		
		Console.WriteLine("Roll   " + "Subject 1   " + "Subject 2   " + "Subject 3   " + "Total") ;
		for(int i=0; i<roll.Length; ++i) {
			Console.WriteLine("  " + roll[i] + "   " + "      " + sub1[i] + "   " + "      " + sub2[i] + "   " + "      " + sub3[i] + "   " + "     " + total[i]) ;
		}
	}
	public static void Main() {
		int size = 5 ;
		int[] roll = new int[size] ;
		int[] sub1 = new int[size] ;
		int[] sub2 = new int[size] ;
		int[] sub3 = new int[size] ;
		int[] total = new int[size] ;
		
		int maxMarks1 = int.MinValue ;
		int maxMarks2 = int.MinValue ;
		int maxMarks3 = int.MinValue ;
		int maxTotal = int.MinValue ;
		
		Console.WriteLine("Enter data of students...") ;
		Console.WriteLine() ;
		
		for(int i=0; i<size; ++i) {
			
			Console.WriteLine("Student - 1...") ;
			
			Console.Write("Enter Roll No. : ") ;
			roll[i] = int.Parse(Console.ReadLine()) ;
			
			Console.Write("Enter marks of Subject 1 : ") ;
			sub1[i] = int.Parse(Console.ReadLine()) ;
			maxMarks1 = Math.Max(maxMarks1, sub1[i]) ;
			
			Console.Write("Enter marks of Subject 2 : ") ;
			sub2[i] = int.Parse(Console.ReadLine()) ;
			maxMarks2 = Math.Max(maxMarks2, sub2[i]) ;
			
			Console.Write("Enter marks of Subject 3 : ") ;
			sub3[i] = int.Parse(Console.ReadLine()) ;
			maxMarks3 = Math.Max(maxMarks3, sub3[i]) ;
			
			total[i] = sub1[i] + sub2[i] + sub3[i] ;
			maxTotal = Math.Max(maxTotal, total[i]) ;
		}
		
		Console.WriteLine() ;
		
		PrintResult(roll, sub1, sub2, sub3, total) ;
		
		Console.WriteLine() ;
		
		Console.WriteLine("Highest total marks = " + maxTotal + " is obtained by " + roll[Array.IndexOf(total, maxTotal)]) ;
		Console.WriteLine("Highest marks in subject 1 = " + maxMarks1 + " is obtained by " + roll[Array.IndexOf(sub1, maxMarks1)]) ;
		Console.WriteLine("Highest marks in subject 2 = " + maxMarks2 + " is obtained by " + roll[Array.IndexOf(sub2, maxMarks2)]) ;
		Console.WriteLine("Highest marks in subject 3 = " + maxMarks3 + " is obtained by " + roll[Array.IndexOf(sub3, maxMarks3)]) ;
	}
}