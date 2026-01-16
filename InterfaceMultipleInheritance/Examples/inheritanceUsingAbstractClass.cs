using System;
using System.Collections.Generic;
using System.Text;
namespace InheritanceUsingAbstractClass
{
	class Program
	{
		static void Main()
		{
			ABS[] aArray = new ABS[3] ;
			aArray[0] = new Class1(1, 2, "Ths is the first value in array.");
			aArray[1] = new Class1(3, 4, "Ths is the next value in array.");
			aArray[2] = new Class2(5, 6);
			for(int i = 0; i < 3; i++)
			{
				aArray[i].show();
			}
		}
	}             // end class Program
	public abstract class ABS
	{
		// constructor takes two integers to fix location on the console
		public ABS(int top, int left)
		{
			this.top = top;
			this.left = left;
		}
		public abstract void show();
		protected int top;
		protected int left;
	}			// end class Window
	// Class1 derives from ABS
	public class Class1 : ABS
	{
		// constructor adds a parameter
		public Class1(int top, int left, string contents) : base(top, left)  // call base constructor
		{
			class1values = contents ;
		}
		// an overridden version implementing the abstract method
		public override void show()
		{
			Console.WriteLine("This is overriding the method show declared in \n abstract class ABS : {0}\n", class1values);
		}
		private string class1values;  // new member variable
	}       // end class Class1
	public class Class2 : ABS{
		public Class2(int top, int left) : base(top, left){}
		// implement the abstract method
		public override void show()
		{
			Console.WriteLine("Overriding again the show method in Class2. \n", top, left);
		}
	}         // end class Class2
}