using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap11
{
	enum DateMonth : long
	{
		oct = 10,
		nov = 20,
		dec
	}
	class Program
	{
		static void Main(string[] args)
		{
			long a = (long)DateMonth.oct;
			long b = (long)DateMonth.nov;
			long c = (long)DateMonth.dec;
			Console.WriteLine("October = {0}, November = {1}, December = {2}", a, b, c);
		}
	}
}


/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap11
{
	enum DateMonth : long
	{
		int oct = 10,
		int nov = 20,
		int dec
	}
	class Program
	{
		static void Main(string[] args)
		{
			long a = DateMonth.oct;
			long b = DateMonth.nov;
			long c = DateMonth.dec;
			Console.Writeline("October = {0}, November = {1}, December = ", a, b, c);
		}
	}
}*/