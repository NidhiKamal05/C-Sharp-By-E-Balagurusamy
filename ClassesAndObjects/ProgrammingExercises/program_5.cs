using System ;
class Integer {
	public int num1, num2 ;
	public Integer(int a, int b) {
		num1 = a ;
		num2 = b ;
	}
	public void Swap(ref int a, ref int b) {
		// int t = a ;
		// a = b ;
		// b = t ;
		a = a + b ;
		b = a - b ;
		a = a - b ;
	}
}
class Test {
	public static void Main() {
		Integer n = new Integer(10, 20) ;
		int a = 5, b = 4 ;
		Console.WriteLine("a = " + a + ", b = " + b) ;
		n.Swap(ref a, ref b) ;
		Console.WriteLine("a = " + a + ", b = " + b) ;
	}
}