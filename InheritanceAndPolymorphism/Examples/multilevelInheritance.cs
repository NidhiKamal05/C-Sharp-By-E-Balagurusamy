// Multilevel Inheritance and Function Overriding
using System;
using System.Collections.Generic;
using System.Text;
namespace Multilevel_Inheritance
{
	class BaseClass
	{
		public int num1, num2, num3;
		public virtual int function1()
		{
			Console.WriteLine("Base Class: function1() returning 1 called.");
			return 1;
		}
		public virtual int function2()
		{
			Console.WriteLine("Base Class: function2() returning 2 called.");
			return 2;
		}
		public virtual int function3()
		{
			Console.WriteLine("Base Class: function3() returning 3 called.");
			return 3;
		}
		public BaseClass()
		{
			Console.WriteLine("\nBase Class: Constructor called.");
			num1 = function1();
			num2 = function2();
			num3 = num1 + num2 + function3();
		}
		public static int Main()
		{
			InheritedClass1 ic = new InheritedClass1();
			InheritedClass2 ic2 = new InheritedClass2();
			InheritedClass3 ic3 = new InheritedClass3();
			Console.WriteLine("\nThe value of num1 is " + ic.num1);
			Console.WriteLine("The value of num2 is " + ic2.num2);
			Console.WriteLine("The value of num3 is " + ic3.num3);
			return 0;
		}
	}
	class InheritedClass1 : BaseClass
	{
		public InheritedClass1()
		{
			Console.WriteLine("Inherited Class1: Constructor called.");
		}
		public override int function1()
		{
			Console.WriteLine("Inherited Class: function1() returning 10 called.");
			return 10;
		}
	}
	class InheritedClass2 : BaseClass
	{
		public InheritedClass2()
		{
			Console.WriteLine("Inherited Class2: Constructor called.");
		}
		public override int function2()
		{
			Console.WriteLine("Inherited Class: function2() returning 20 called.");
			return 20;
		}
	}
	class InheritedClass3 : BaseClass
	{
		public InheritedClass3()
		{
			Console.WriteLine("Inherited Class3: Constructor called.");
		}
		public override int function3()
		{
			Console.WriteLine("Inherited Class: function3() returning 30 called.");
			return 30;
		}
	}
}