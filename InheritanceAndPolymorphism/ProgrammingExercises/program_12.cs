using System ;

class Shape {
	protected double x ;
	protected double y ;
	public void Set(double a, double b) {
		x = a ;
		y = b ;
	}
	public virtual void Area() {
		Console.WriteLine("\nCalculate area of a shape....") ;
	}
}

class Triangle : Shape
{
	// public override void Area() {
		// double ar = (x * y) / 2 ;
		// Console.WriteLine("\nArea of a triangle with base = " + x + " and height = " + y + " is " + ar) ;
	// }
}

class Rectangle : Shape
{
	public override void Area() {
		double ar = x * y ;
		Console.WriteLine("\nArea of a rectangle with length = " + x + " and breadth = " + y + " is " + ar) ;
	}
}

class Program {
	public static void Main() {
		Triangle tri = new Triangle() ;
		Rectangle rect = new Rectangle() ;
		
		tri.Set(3, 7) ;
		rect.Set(3, 5) ;
		
		tri.Area() ;
		rect.Area() ;
	}
}