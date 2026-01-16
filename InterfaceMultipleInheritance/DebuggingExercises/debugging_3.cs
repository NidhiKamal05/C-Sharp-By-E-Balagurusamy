using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap14
{
	class Program
	{
		public class ShowValues
		{
			public virtual void Show(){}
		}
		public class CharContainer : ShowValues
		{
			public override void Show()
			{
				// Do character type sorting here.
				Console.WriteLine("From CharContainer.");
			}
		}
		public class NumberContainer : ShowValues
		{
			public override void Show()
			{
				// Do numeric type sorting here.
				Console.WriteLine("From NumberContainer.");
			}
		}
		public void ShowAll(ShowValues[] sortobj)
		{
			foreach (ShowValues sv in sortobj)
			{
				sv.Show();
			}
		}
		static void Main(string[] args) {
			Program Obj = new Program();
			Obj.ShowAll(new ShowValues[2] {new CharContainer(), new NumberContainer()});
		}
	}
}





/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap14
{
	class Program
	{
		public class ShowValues
		{
			void Show();
		}
		public class CharContainer :: ShowValues
		{
			public void Show()
			{
				// Do character type sorting here.
				Console.WriteLine("From CharContainer.");
			}
		}
		public class NumberContainer :: ShowValues
		{
			public void Show()
			{
				// Do numeric type sorting here.
				Console.WriteLine("From NumberContainer.");
			}
		}
		public void ShowAll(ShowValues[] sortobj)
		{
			foreach (ShowValues sv in sortobj)
			{
				sv.Show();
			}
		}
		static void Main(string[] args) {
			Program Obj = new Program();
			obj.ShowAll(new ShowValues[2] {new CharContainer(), new NumberContainer()});
		}
	}
}*/