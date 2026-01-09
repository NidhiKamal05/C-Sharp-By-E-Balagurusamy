using System;
using System.Collections.Generic;
using System.Text;
namespace InnerClassExample
{
	public class nestedClass
	{
		public static void Main()
		{
			outerClass obj2 = new outerClass();
			obj2.show();
			outerClass.innerClass obj1 = new outerClass.innerClass();
			obj1.display();
		}
	}
	public class outerClass
	{
		public void show()
		{
			System.Console.WriteLine("This message is from the class outerClass containing the\n nested class innerClass.\n");
		}
		// public innerClass abc()
		// {
			// return new innerClass();
		// }
		public class innerClass
		{
			public void display()
			{
				System.Console.WriteLine("This is a nested class example in C#.\n This info is in the innermost class innerClass.");
			}
		}
	}
}