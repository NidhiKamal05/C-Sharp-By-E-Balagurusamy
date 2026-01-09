using System;
using System.Collections.Generic;
using System.Text;
namespace IndexersExample
{
	class IndexersEx
	{
		private string[] TechCompanies = new string[14];
		public string this[int indexVal]
		{
			get
			{
				if(indexVal < 0 || indexVal >= 11)
					return "empty";
				else
					return TechCompanies[indexVal];
			}
			set
			{
				if(!(indexVal < 0 || indexVal >= 11))
					TechCompanies[indexVal] = value;
			}
		}
	}
	class theMainClass
	{
		public static void Main()
		{
			IndexersEx Obj = new IndexersEx();
			Obj[0] = "Infosys";
			Obj[3] = "Wipro Infotech";
			Obj[5] = "Satyam Computers";
			Obj[6] = "Patni Computers";
			Obj[8] = "Hexaware";
			Obj[10] = "Polaris Software";
			Obj[12] = "Mastek Computers";
			Obj[14] = "HCL";
			Console.WriteLine("This is a List of IT Companies in india.\n");
			for(int i=0; i<=14; i++)
			{
				Console.WriteLine("This name of IT Company at index {0} : {1}", i, Obj[i]);
			}
		}
	}
}