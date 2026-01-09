using System ;
class Date {
	public int day, month, year ;
	public Date(int d, int m, int y) {
		day = d ;
		month = m ;
		year = y ;
	}
	public Date(int date) {
		int d = 0, m = 0, y = 0 ;
		for(int i=0; i<2; ++i) {
			d = (d * 10) + (date % 10) ;
			date /= 10 ;
		}
		d = Rev(d) ;
		for(int i=0; i<2; ++i) {
			m = (m * 10) + (date % 10) ;
			date /= 10 ;
		}
		m = Rev(m) ;
		y = date ;
		day = d ;
		month = m ;
		year = y ;
	}
	public int Rev(int num) {
		int rev = 0 ;
		while(num != 0) {
			rev = (rev * 10) + (num % 10) ;
			num /= 10 ;
		}
		return rev ;
	}
	public void Display() {
		Console.WriteLine(day + "/" + month + "/" + year) ;
	}
}
class Test {
	public static void Main() {
		Date date1 = new Date(15, 8, 1945) ;
		Date date2 = new Date(19450815) ;
		date1.Display() ;
		date2.Display() ;
	}
}