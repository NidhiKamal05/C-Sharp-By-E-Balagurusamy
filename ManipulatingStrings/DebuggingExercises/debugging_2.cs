using System;
using System.Collections.Generic;
using System.Text;

namespace debugApp2_chap10
{
	class Program
	{
		public void Display()
		{
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			string str2 = "";
			Console.Write("Please enter another string : ");
			str2 = Console.ReadLine();
			Console.WriteLine(" string str1 : {0}", str1);
			Console.WriteLine(" inserting value of string str1 in string str2;");
			str2 = str1;
			Console.WriteLine("str1: {0}\nstr2: {1}", str1, str2);
			Console.WriteLine("str1 == str2? {0}", str1 == str2);
			Console.WriteLine("\nstring str2 = string.Copy( str1 );");
			Console.WriteLine(" Copying string str1 in string str3");
			string str3 = string.Copy(str1);
			Console.WriteLine("str1: {0}\nstr3: {1}", str1, str3);
			Console.WriteLine("str1 == str3? {0}", str1 == str3);
			Console.WriteLine("\nstr2 = \"New string\";");
			str1 = "New string" ;
			Console.WriteLine("str1: {0}\nstr2: {1}", str1, str2);
			Console.WriteLine("str1 == str2? {0}", str1 == str2);
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display();
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;

namespace debugApp2_chap10
{
	class Program
	{
		public void Display()
		{
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			string str2 = "";
			Console.Write("Please enter another string : ");
			str2 = Console.ReadLine();
			Console.WriteLine(" string str1 : {0}", str1);
			Console.WriteLine(" inserting value of string str1 in string str2;");
			str2 == str1;
			Console.WriteLine("str1: {0}\nstr2: {1}", str1, str2);
			Console.WriteLine("str1 == str2? {0}", str1 == str2);
			Console.WriteLine("\nstring str2 = string.Copy( str1 );");
			Console.WriteLine(" Copying string str1 in string str3");
			str3 = string(copy(str1, str2));
			Console.WriteLine("str1: {0}\nstr3: {1}", str1, str3);
			Console.WriteLine("str1 == str3? {0}", str1 == str3);
			Console.WriteLine("\nstr2 = \"New string\";");
			str1 = "New string" ;
			Console.WriteLine("str1: {0}\nstr2: {1}", str1, str2);
			Console.WriteLine("str1 == str2? {0}", str1 == str2);
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display();
		}
	}
}*/