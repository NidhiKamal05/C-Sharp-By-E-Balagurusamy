using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap12
{
	public class TimeDate
	{
		public void DisplayCurrentTime_Date()
		{
			Console.WriteLine("The current Date is ");
			Console.WriteLine(DateTime.Now);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			TimeDate timeObj = new TimeDate();
			timeObj.DisplayCurrentTime_Date();
		}
	}
}

/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp3_chap12
{
	public class TimeDate
	{
		void DisplayCurrentTime_Date()
		{
			Console.WriteLine("The current Date is ");
			Console.WriteLine(DateTime.Now);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			TimeDate timeObj = new TimeDate();
			timeObj.DisplayCurrentTime_Date();
		}
	}
}*/