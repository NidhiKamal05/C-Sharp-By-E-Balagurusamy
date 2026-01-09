using System ;
class Number {
	public int num ;
	public Number() {
		Console.WriteLine("object is created") ;
	}
	public Number(int x) {
		num = x ;
	}
	public int Get() {
		return num ;
	}
	~Number() {
		Console.WriteLine("object is destroyed") ;
	}
}
class Test {
	public static void Main() {
		// Number n1 = new Number() ;
		Number n2 = new Number(20) ;
		Console.WriteLine("num = " + n2.Get()) ;
	}
}