using System ;

class Vector {
	private int[] vals ;
	public Vector(int[] arr) {
		vals = arr ;
	}
	public void Modify(int oldVal, int newVal) {
		bool isFound = false ;
		for(int i=0; i<vals.Length; ++i) {
			if(vals[i] == oldVal) {
				vals[i] = newVal ;
				isFound = true ;
			}
		}
		if(isFound == false) {
			Console.WriteLine(oldVal + " is not found...") ;
		}
	}
	public void Multiply(int scalar) {
		for(int i=0; i<vals.Length; ++i) {
			vals[i] *= scalar ;
		}
	}
	public void Display() {
		int i = 0 ;
		Console.Write("(") ;
		for(i=0; i<vals.Length-1; ++i) {
			Console.Write(vals[i] + ", ") ;
		}
		Console.WriteLine(vals[i] + ")") ;
	}
}

class Test {
	public static void Main() {
		int[] arr = {10, 20, 25, 35, 50, 65, 80} ;
		Vector v = new Vector(arr) ;
		
		Console.WriteLine() ;		
		Console.WriteLine("Initialize....") ;
		v.Display() ;
		
		Console.WriteLine() ;
		Console.WriteLine("Modify....") ;
		v.Modify(25, 30) ;
		v.Display() ;
		
		Console.WriteLine() ;
		Console.WriteLine("Modify....") ;
		v.Modify(55, 60) ;
		v.Display() ;
		
		Console.WriteLine() ;
		Console.WriteLine("Multiply by scalar....") ;
		v.Multiply(2) ;
		v.Display() ;
	}
}