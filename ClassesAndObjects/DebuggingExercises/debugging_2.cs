using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap12
{
	class Program
	{
		static void Main(string[] args)
		{
			Name obj = new Name();
			obj.showinfo();
		}
	}
	class Name
	{
		public void showinfo()
		{
			Console.WriteLine("Hello");
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
namespace DebugApp2_chap12
{
	class Program
	{
		static void Main(string[] args)
		{
			Name obj = new Name();
			obj.showinfo();
		}
	}
	class Name
	{
		public showinfo()
		{
			Console.WriteLine("Hello");
		}
	}
}*/