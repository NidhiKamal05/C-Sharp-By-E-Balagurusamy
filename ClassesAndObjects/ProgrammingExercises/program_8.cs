using System ;
class Time {
	public int minutes, hours ;
	public Time(int h, int m) {
		minutes = m ;
		hours = h ;
	}
	public Time(int m) {
		minutes = m % 60 ;
		hours = m / 60 ;
	}
	public void Display() {
		Console.WriteLine(hours + " hours : " + minutes + " minutes") ;
	}
}
class Test {
	public static void Main() {
		Time t1 = new Time(2, 15) ;
		Time t2 = new Time(100) ;
		t1.Display() ;
		t2.Display() ;
	}
}