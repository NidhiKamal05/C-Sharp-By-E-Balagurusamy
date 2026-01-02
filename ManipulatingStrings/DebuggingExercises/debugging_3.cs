using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace debugApp3_chap10
{
	class Program
	{
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Show();
		}
		public void Show()
		{
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			Regex reg = new Regex(" |, |,");
			StringBuilder sb = new StringBuilder();
			int i = 1;
			foreach(string subString in reg.Split(str1))
			{
				sb.AppendFormat("{0}: {1}\n", i++, subString);
			}
			Console.WriteLine("{0}", sb);
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace debugApp3_chap10
{
	class Program
	{
		static void Main(string[] args)
		{
			Program prg = new Program();
			Show();
		}
		public void Show()
		{
			string str1 = "";
			Console.Write("Please enter a string : ");
			str1 = Console.ReadLine();
			Regex reg = new Regex(" |, |,");
			StringBuilder sb = new StringBuilder();
			int i = 1;
			for(string subString as reg.Split(str1))
			{
				sb.Appendformat("{0}: {1}\n", i++, subString);
			}
			Console.WriteLine("{0}", +sb);
		}
	}
}*/