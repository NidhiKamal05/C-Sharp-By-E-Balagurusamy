using System;
using System.Collections.Generic;
using System.Text;

namespace debugApp1_chap10
{
	class Program
	{
		public void Display()
		{
			// create some strings to work with
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			// constants for the space and comma charcters
			const char Space = ' ';
			const char Comma = ',';
			// array of delimiters to split the sentence with
			char[] spacers = new char[]{Space, Comma};
			// use StringBuilder class to build the ouput string
			StringBuilder sb  = new StringBuilder();
			int increment = 1;
			// splitting the string
			Console.WriteLine("The whole string is displayed below.");
			foreach(string subString in str1.Split(spacers))
			{
				// AppendFormat appends a formatted string
				sb.AppendFormat("{0}: word {1} is at position {0}\n", increment++, subString);				
			}
			Console.WriteLine(sb);
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

namespace debugApp1_chap10
{
	class Program
	{
		public void Display()
		{
			// create some strings to work with
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			// constants for the space and comma charcters
			const char Space = ' ';
			const char Comma = ',';
			// array of delimiters to split the sentence with
			char[] spacers = new char()
			{
				Space;
				Comma;
			};
			// use StringBuilder class to build the ouput string
			StringBuilder sb  = new StringBuilder();
			int increment = 1;
			// splitting the string
			Console.WriteLine("The whole string is displayed below.");
			foreach(string substring in str1.Split(spacers))
			{
				// AppendFormat appends a formatted string
				sb.AppendFormat("{0}: word {1} is at position {0}\n", +increment++, +subString);				
			}
			Console.WriteLine(sb);
		}
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display();
		}
	}
}*/