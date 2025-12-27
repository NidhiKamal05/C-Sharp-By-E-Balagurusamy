/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap9
{
	class Program
	{
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display(1, 2, 3, 4);
			int exArr[] = new int{"23", "33", "43", "53"};
			Console.WriteLine("Example of array.");
			Console.WriteLine("New array elements added.");
			prg.Display(exArr[]);
		}
		public void Display(params int[] val1)
		{
			foreach(int i in val1)
			{
				Console.WriteLine("The array is having : {0}", i);
			}
		}
	}
}*/

using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap9
{
	class Program
	{
		static void Main(string[] args)
		{
			Program prg = new Program();
			prg.Display(1, 2, 3, 4);
			int[] exArr = new int[]{23, 33, 43, 53};
			Console.WriteLine("Example of array.");
			Console.WriteLine("New array elements added.");
			prg.Display(exArr);
		}
		public void Display(params int[] val1)
		{
			foreach(int i in val1)
			{
				Console.WriteLine("The array is having : {0}", i);
			}
		}
	}
}