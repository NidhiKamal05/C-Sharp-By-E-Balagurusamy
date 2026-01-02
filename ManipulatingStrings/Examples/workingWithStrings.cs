using System;
using System.Collections.Generic;
using System.Text;
namespace WorkingWithstrings
{
	class Program
	{
		public void Display()
		{
			string str1 = "";
			Console.Write("Enter a small string : ");
			str1 = Console.ReadLine();
			string str2 = "";
			Console.Write("Enter a small string : ");
			str2 = Console.ReadLine();
			
			string str3 = @"C# 2005 is one of the core Languages of .NET. It provides a custom .NET development platform for developing applications.";
			
			// the string copy method
			string s5 = string.Copy(str2);
			Console.WriteLine("s5 is having the value of string str2; {0}", s5);
			
			// Two useful properties: the index and the length
			Console.WriteLine("\nString str5 is {0} characters long.", s5.Length);
			Console.WriteLine("The value of 5th character is {0}\n", str3[4]);
			
			// test whether a string ends with a set of characters
			Console.WriteLine("str3:{0}\nEnds with development?: {1}\n", str3, str3.EndsWith("platform"));
			Console.WriteLine("ends with applications?: {0}", str3.EndsWith("applications"));
			
			// return the index of the substring
			Console.WriteLine("\nThe first occurrence of development");
			Console.WriteLine("in str3 is at position {0}\n", str3.IndexOf("development"));
			
			// insert the word nice in development"
			string str10 = str3.Insert(73, "nice ");
			Console.WriteLine("str10: {0}\n", str10);
			
			// Combining the two as follows:
			string str11 = str3.Insert(str3.IndexOf("applications"), "nice ");
			Console.WriteLine("str11: {0}\n", str11);
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display();
		}
	}
}