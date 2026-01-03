using System;
using System.Collections.Generic;
using System.Text;
namespace EnumerationExample
{
	enum Staff
	{
		Directors,
		Managers,
		Executives
	}
	enum Company
	{
		NewSoftLtd,
		TechnologiesInc,
		HillRockLtd
	}
	class Program
	{
		public static void Show(Staff st)
		{
			switch(st)
			{
				case Staff.Directors:
					Console.WriteLine("You are a Director.");
					break;
				case Staff.Managers:
					Console.WriteLine("You are a Manager.");
					break;
				case Staff.Executives:
					Console.WriteLine("You are a Executive.");
					break;
				default:
					break;
			}
		}
		public static void CompDisplay(Company com)
		{
			switch(com)
			{
				case Company.NewSoftLtd:
					Console.WriteLine("NewSoftLtd.");
					break;
				case Company.TechnologiesInc:
					Console.WriteLine("TechnologiesInc.");
					break;
				case Company.HillRockLtd:
					Console.WriteLine("HillRockLtd.");
					break;
				default:
					break;
			}
		}
		static void Main(string[] args)
		{
			Staff st;
			st = Staff.Directors;
			Console.WriteLine("This is an example of enumeration in C#.\n");
			Show(st);
			Company com;
			com = Company.NewSoftLtd;
			Console.Write("Director belongs to Company : ");
			CompDisplay(com);
		}
	}
}