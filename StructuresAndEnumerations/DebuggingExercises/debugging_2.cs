using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap11
{
	struct StructExample {
		public int m;
		public StructExample(int n) {
			m=n*n;
		}
		public void Show() {
			System.Console.WriteLine("This is from Show method in a Struct.");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			StructExample st = new StructExample(10);
			Console.WriteLine(st.m);
			st.Show();
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugapp2_chap11
{
	struct StructExample {
		public int m;
		public StructExample(int n) {
			m=n*n;
		}
		void Show() {
			System.Console.WriteLine("This is from Show method in a Struct.");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			StructExample st;
			System.Console.WriteLine(st.i);
			st.show();
		}
	}
}*/