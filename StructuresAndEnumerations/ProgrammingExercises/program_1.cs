using System ;

class Program {
	struct DateOfBirth {
		public int date ;
		public int month ;
		public int year ;
	}
	static void Main(string[] args) {
		DateOfBirth d ;
		d.date = 15 ;
		d.month = 06 ;
		d.year = 75 ;
		Console.WriteLine("My date of birth is " + d.date + "/" + d.month + "/" + d.year) ;
	}
}