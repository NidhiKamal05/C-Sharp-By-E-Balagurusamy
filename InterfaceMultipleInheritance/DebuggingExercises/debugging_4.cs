using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp4_chap14
{
	interface Inter1
	{
		void Display();
	}
	class Class1
	{
		public void Display()
		{
			Console.WriteLine("This message is from Class1.");
		}
	}
	class Class2 : Inter1
	{
		public void Display()
		{
			Console.WriteLine("This message is from Class2.");
		}
	}
	class Class3
	{
		public void ShowMessage(object obj)
		{
			Inter1 show;
			show = obj as Inter1;
			if(show != null)
				show.Display();
		}
		public void Display()
		{
			Class1 cl1 = new Class1();
			Class2 cl2 = new Class2();
			ShowMessage(cl1);
			ShowMessage(cl2);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Class3 cl3 = new Class3();
			// cl3.ShowMessage();
			cl3.Display();
		}
	}
}




/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp4_chap14
{
	interface Inter1
	{
		void Display();
	}
	private class Class1
	{
		public void Display()
		{
			Console.WriteLine("This message is from Class1.");
		}
	}
	private class Class2 : Inter1
	{
		public void Display()
		{
			Console.WriteLine("This message is from Class2.");
		}
	}
	private class Class3
	{
		void ShowMessage(object obj)
		{
			Inter1 show;
			show = obj as Inter1;
			if(show != null)
				show.Display();
		}
		void Display()
		{
			class1 cl1 = new class1();
			class2 cl2 = new class2();
			ShowMessage(cl1);
			ShowMessage(cl2);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			class3 cl3 = new class3();
			cl3.ShowMessage();
		}
	}
}*/