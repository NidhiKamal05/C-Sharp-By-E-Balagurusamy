using System ;

class Program {
	struct DateOfBirth {
		int date ;
		int month ;
		int year ;
		public DateOfBirth(int d, int m, int y) {
			date = d ;
			month = m ;
			year = y ;
		}
		public void Disp() {
			Console.WriteLine("My date of birth is " + date + "/" + month + "/" + year) ;
		}
	}
	static void Main(string[] args) {
		DateOfBirth d = new DateOfBirth(15, 06, 75) ;		
		d.Disp() ;
	}
}