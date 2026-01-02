using System;
using System.Collections.Generic;
using System.Text;
namespace SearchString
{
	class Program
	{
		public void Display()
		{
			string str1 = "";
			Console.Write("Enter a string: ");
			str1 = Console.ReadLine();
			string str2 = "";
			Console.Write("Enter another string: ");
			str2 = Console.ReadLine();
			
			string str3 = "C# 2005 is developed in Visual Studio 2005 IDE";
			Console.WriteLine("String str3 is : {0}", str3);
			
			// the string copy method
			string str5 = string.Copy(str2);
			Console.WriteLine("String str5 is copied from str2: {0}", str5);
			Console.WriteLine("\nString str5 is {0} characters long.", str5.Length);
			
			Console.WriteLine("The 10th character of string str3 is : {0}", str3[9]);
			
			// check if a string ends with a set of characters
			Console.WriteLine("String str3: {0}\nEnds with IDE?: {1}\n", str3, str3.EndsWith("IDE"));
			Console.WriteLine("Ends with Studio?: {0}", str3.EndsWith("Studio"));
			
			// return the index of the substring
			Console.WriteLine("\nThe first time character 'a' occured in string str1 at position : {0}", str1.IndexOf("a")+1);
			
			string str6 = str2.Insert(6, "hello");
			Console.WriteLine("'hello' is inserted in string str6. String s6 is now : {0}\n", str6);
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display();
		}
	}
}