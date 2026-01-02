using System;
using System.Collections.Generic;
using System.Text;
namespace StringExample
{
	class Program
	{
		public void Show()
		{
			string str1="";
			string str2="";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			Console.Write("Please enter another string : ");
			str2 = Console.ReadLine();
			StringBuilder builder1 = new StringBuilder(str1, 4);
			StringBuilder builder2 = new StringBuilder(str2, 4);
			int cap = builder1.EnsureCapacity(55);
			Console.Write("string str1 appended to : ");
			builder1.Append(". This is a class test.");
			Console.WriteLine(builder1);
			Console.Write("string str2 inserted with : ");
			builder2.Insert(2, " String Builder");
			Console.WriteLine(builder2);
			Console.WriteLine("\nSecond character of string2 removed.\n");
			builder2.Remove(2, 4);
			Console.WriteLine(builder2);
			builder1.Replace(' ', '*');
			Console.WriteLine("\nSpaces removed from string1\n");
			Console.WriteLine(builder1);
			Console.WriteLine("\nLength of string1 is: " + builder1.Length.ToString());
			Console.WriteLine("\nLength of string2 is: " + builder2.Length.ToString());
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Show();
		}
	}
}