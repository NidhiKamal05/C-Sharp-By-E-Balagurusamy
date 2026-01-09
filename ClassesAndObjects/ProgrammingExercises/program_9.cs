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
	public void Increment() {
		++minutes ;
		if(minutes >= 60) {
			minutes = 0 ;
			++hours ;
		}
		if(hours >= 24) {
			hours = 0 ;
		}
	}
	
	public void Decrement() {
		--minutes ;
		if(minutes < 0) {
			minutes = 59 ;
			--hours ;
		}
		if(hours < 0) {
			hours = 23 ;
		}
	}
	public void Display() {
		Console.WriteLine(hours + " hours : " + minutes + " minutes") ;
	}
}
class Test {
	public static void Main() {
		Time t1 = new Time(12, 30) ;
		Time t2 = new Time(100) ;
		t1.Display() ;
		t2.Display() ;
		
		Console.WriteLine() ;
		
		Time t3 = new Time(23, 59) ;
		Console.WriteLine("Before Increment()....") ;
		t3.Display() ;
		Console.WriteLine("After Increment()....") ;
		t3.Increment() ;
		t3.Display() ;
		
		Console.WriteLine() ;
		
		Time t4 = new Time(0, 0) ;
		Console.WriteLine("Before Decrement()....") ;
		t4.Display() ;
		Console.WriteLine("After Decrement()....") ;
		t4.Decrement() ;
		t4.Display() ;
	}
}