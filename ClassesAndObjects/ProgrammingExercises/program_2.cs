using System ;
class Number {
	public int num ;
	public Number() {
		Console.WriteLine("object is created") ;
	}
	public void Set(int x) {
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
		Number n = new Number() ;
		n.Set(2002) ;
		Console.WriteLine("num = " + n.Get()) ;
	}
}