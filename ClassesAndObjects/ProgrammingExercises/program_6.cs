using System ;
class Date {
	public int day, month, year ;
	public Date(int d, int m, int y) {
		day = d ;
		month = m ;
		year = y ;
	}
	public void Display() {
		Console.WriteLine(day + "/" + month + "/" + year) ;
	}
}
class Test {
	public static void Main() {
		Date date = new Date(15, 8, 1945) ;
		date.Display() ;
	}
}