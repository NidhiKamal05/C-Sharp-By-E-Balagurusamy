using System ;
class Number {
	public int num ;
	public Number() {
		Console.WriteLine("object is created") ;
	}
	public int SetGet {
		set {
			num = value ;
		}
		get {
			return num ;
		}
	}
	~Number() {
		Console.WriteLine("object is destroyed") ;
	}
}
class Test {
	public static void Main() {
		Number n = new Number() ;
		n.SetGet = 2 ;
		Console.WriteLine("num = " + n.SetGet) ;
	}
}