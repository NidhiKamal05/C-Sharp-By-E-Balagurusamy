using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap13
{
	class Program
	{
		static void Main(string[] args)
		{
			Derived d1 = new Derived();
			Console.WriteLine("{0}, {1}, {2}", d1.x, d1.y, d1.z); // displays 10, 20, 30
			d1.show(); // displays 'Base Method'
		}
	}
	class Base
	{
		public int x = 10;
		public int y = 20;
		public void show()
		{
			Console.WriteLine("Base Method");
		}
	}
	class Derived : Base
	{
		public int z = 30;
	}
}


/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap13
{
	class Program
	{
		static void Main(string[] args)
		{
			Derived d1 = new Derived();
			Console.WriteLine("{0}, {1}, {2}", d1.x, d1.y, d1.z); // displays 10, 20, 30
			d1.show(); // displays 'Base Method'
		}
	}
	class Base
	{
		int x = 10;
		int y = 20;
		public void show()
		{
			Console.WriteLine("Base Method");
		}
	}
	class Derived : Base
	{
		public int z = 30;
	}
}*/