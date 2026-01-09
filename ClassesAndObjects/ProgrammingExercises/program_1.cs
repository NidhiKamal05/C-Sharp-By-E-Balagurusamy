using System ;
class Number {
	public int num ;
	public Number() {
		Console.WriteLine("object is created") ;
	}
	~Number() {
		Console.WriteLine("object is destroyed") ;
	}
}
class Test {
	public static void Main() {
		Number n = new Number() ;
		n.num = 5 ;
		Console.WriteLine("num = " + n.num) ;
	}
}