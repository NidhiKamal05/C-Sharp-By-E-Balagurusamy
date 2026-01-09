using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp4_chap12
{
	class Class2
	{
		int a;
		int b;
		public Class2(int i, int j)
		{
			a = i;
			b = j;
		}
		public void Display()
		{
			Console.WriteLine(a + b);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Class2 cl = new Class2(5, 6);
			Console.Write("The output is : ");
			cl.Display();
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp4_chap12
{
	class Class2
	{
		int a;
		int b;
		Class2(i, j)
		{
			a = int i;
			b = int j;
		}
		void Display()
		{
			Console.WriteLine(a + b);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Class2 cl = new Class2();
			Console.Write("The output is : ");
			cl.Display();
		}
	}
}*/