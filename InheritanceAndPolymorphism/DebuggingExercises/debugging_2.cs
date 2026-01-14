using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap13
{
	class Program
	{
		static void Main(string[] args)
		{
			DerivedClass dc = new DerivedClass();
		}
	}
	public class BaseClass
	{
		public BaseClass()
		{
			Console.WriteLine("This is Base class's default constructor");
		}
	}
	public class DerivedClass : BaseClass
	{
		
	}
}


/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap13
{
	class Program
	{
		static void Main(string[] args)
		{
			DerivedClass dc = new DerivedClass();
		}
	}
	class BaseClass
	{
		private BaseClass()
		{
			Console.WriteLine("This is Base class's default constructor");
		}
	}
	public class DerivedClass : BaseClass
	{
		
	}
}*/