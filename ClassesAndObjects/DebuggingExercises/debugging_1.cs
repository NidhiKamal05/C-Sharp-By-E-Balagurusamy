using System;
using System.Collections.Generic;
using System.Text;
namespace DebugApp1_chap12
{
	class Program
	{
		static void Main(string[] args)
		{
			Name nm = new Name();
			nm.Name1 = "Steve";
			nm.Address = "Washington";
			nm.ShowInfo();
		}
	}
	class Name
	{
		public string Name1;
		public string Address;
		public void ShowInfo()
		{
			Console.WriteLine("{0} is in city {1}", Name1, Address);
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
namespace DebugApp1_chap12
{
	class Program
	{
		static void Main(string[] args)
		{
			Name nm = new Name();
			nm.Name1 = "Steve";
			nm.Address = "Washington";
			nm.ShowInfo();
			Console.ReadLine();
		}
	}
	class Name
	{
		public string Name1;
		public string Address;
		public void ShowInfo()
		{
			Console.WriteLine("{0} is in city {1}", + Name1, +Address);
		}
	}
}*/