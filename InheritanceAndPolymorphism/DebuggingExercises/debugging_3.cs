using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap13
{
	public class BaseClass
	{
		public virtual void Show()
		{
			Console.WriteLine("This is BaseClass Method");
		}
	}
	public class DerivedClass : BaseClass
	{
		public override void Show()
		{
			Console.WriteLine("This is a overriden method Show of Base Class in Derived Class");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			BaseClass bc = new BaseClass();
			bc.Show();  // Displays 'Base Method'
		}
	}
}


/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap13
{
	class BaseClass
	{
		public void Show()
		{
			Console.WriteLine("This is BaseClass Method");
		}
	}
	public class DerivedClass :: BaseClass
	{
		public override void Show()
		{
			Console.WriteLine("This is a overriden method Show of Base Class in Derived Class");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			BaseClass bc = new DerivedClass();
			bc.Show();  // Displays 'Base Method'
		}
	}
}*/