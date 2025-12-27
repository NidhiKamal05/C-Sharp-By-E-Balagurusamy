/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap9
{
	class Program
	{
		int m=0;int n = 0;
		static void Main(string[] args)
		{
			const int rowValues = 7;
			const int columnValues = 4;
			int[] recArr = 
			{
				{1, 14, 16, 27}, {2, 24, 36, 37}, {3, 34, 46, 47}, {4, 44, 56, 57}, {5, 54, 66, 67}, {6, 64, 76, 77}, {7, 74, 86, 87}
			};
			Console.WriteLine("This is an example of rectangular Array.");
			for(m=0; m<rowValues; m++)
			{
				for(n=0; n<columnValues; n++)
				{
					Console.WriteLine("[{0}{1}] = {2}", m, n, recArr[]);
				}
			}
		}
	}
}*/

using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap9
{
	class Program
	{
		static int m = 0;
		static int n = 0;
		static void Main(string[] args)
		{
			const int rowValues = 7;
			const int columnValues = 4;
			int[,] recArr = 
			{
				{1, 14, 16, 27}, {2, 24, 36, 37}, {3, 34, 46, 47}, {4, 44, 56, 57}, {5, 54, 66, 67}, {6, 64, 76, 77}, {7, 74, 86, 87}
			};
			Console.WriteLine("This is an example of rectangular Array.");
			for(m=0; m<rowValues; m++)
			{
				for(n=0; n<columnValues; n++)
				{
					Console.WriteLine("[{0},{1}] = {2}", m, n, recArr[m,n]);
				}
			}
		}
	}
}