using System ;

class One {
	public void displayOne() {
		Console.Write("C Sharp") ;
	}
}

class Two {
	public void displayTwo() {
		Console.Write("Programming") ;
	}
}

class A {
	public static void Main() {
		One o = new One() ;		
		o.displayOne() ;
		Console.Write(" ") ;
		Two t = new Two() ;		
		t.displayTwo() ;
	}
}